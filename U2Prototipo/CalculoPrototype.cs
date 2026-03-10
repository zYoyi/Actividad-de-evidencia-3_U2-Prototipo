using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Prototipo
{
    public class CalculoPrototype : ExamenPrototype
    {
        public CalculoPrototype()
        {
            _claveMateria = "MAT-110";
            _materia = "Cálculo Integral";
            _tipo = "Teórico";
            _modalidad = "Presencial";
            _cantidadPreguntas = 15;
            _porcentajeRevision = 70;
        }

        public override ExamenPrototype Clone()
        {
            return (CalculoPrototype)this.MemberwiseClone();
        }
    }
}
