using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Prototipo
{
    public class ProgramacionOOPrototype : ExamenPrototype
    {
        public ProgramacionOOPrototype()
        {
            _claveMateria = "POO-201";
            _materia = "Programación Orientada a Objetos";
            _tipo = "Práctico";
            _modalidad = "Presencial";
            _cantidadPreguntas = 25;
            _porcentajeRevision = 40;
        }

        public override ExamenPrototype Clone()
        {
            return (ProgramacionOOPrototype)this.MemberwiseClone();
        }
    }
}