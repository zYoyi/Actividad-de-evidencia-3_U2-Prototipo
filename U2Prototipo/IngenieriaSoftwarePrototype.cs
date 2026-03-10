using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Prototipo
{
    public class IngenieriaSoftwarePrototype : ExamenPrototype
    {
        public IngenieriaSoftwarePrototype()
        {
            _claveMateria = "IS-420";
            _materia = "Ingeniería de Software";
            _tipo = "Teórico";
            _modalidad = "Presencial";
            _cantidadPreguntas = 22;
            _porcentajeRevision = 55;
        }

        public override ExamenPrototype Clone()
        {
            return (IngenieriaSoftwarePrototype)this.MemberwiseClone();
        }
    }
}
