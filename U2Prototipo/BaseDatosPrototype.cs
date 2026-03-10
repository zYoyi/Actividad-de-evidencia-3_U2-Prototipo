using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Prototipo
{
    public class BaseDatosPrototype : ExamenPrototype
    {
        public BaseDatosPrototype()
        {
            _claveMateria = "BDD-301";
            _materia = "Base de Datos";
            _tipo = "Teórico";
            _modalidad = "Laboratorio";
            _cantidadPreguntas = 30;
            _porcentajeRevision = 60;
        }

        public override ExamenPrototype Clone()
        {
            return (BaseDatosPrototype)this.MemberwiseClone();
        }
    }
}
