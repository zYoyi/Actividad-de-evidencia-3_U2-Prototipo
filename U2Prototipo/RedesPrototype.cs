using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Prototipo
{
    public class RedesPrototype : ExamenPrototype
    {
        public RedesPrototype()
        {
            _claveMateria = "RED-210";
            _materia = "Redes";
            _tipo = "Teórico-Práctico";
            _modalidad = "Presencial";
            _cantidadPreguntas = 28;
            _porcentajeRevision = 45;
        }

        public override ExamenPrototype Clone()
        {
            return (RedesPrototype)this.MemberwiseClone();
        }
    }
}
