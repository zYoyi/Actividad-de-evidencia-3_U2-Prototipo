using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Prototipo
{
    public class ProbabilidadPrototype : ExamenPrototype
    {
        public ProbabilidadPrototype()
        {
            _claveMateria = "EST-205";
            _materia = "Probabilidad y Estadística";
            _tipo = "Teórico";
            _modalidad = "Presencial";
            _cantidadPreguntas = 20;
            _porcentajeRevision = 50;
        }

        public override ExamenPrototype Clone()
        {
            return (ProbabilidadPrototype)this.MemberwiseClone();
        }
    }
}
