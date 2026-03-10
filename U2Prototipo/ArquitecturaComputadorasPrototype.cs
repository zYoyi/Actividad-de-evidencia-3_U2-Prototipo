using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Prototipo
{
    public class ArquitecturaComputadorasPrototype : ExamenPrototype
    {
        public ArquitecturaComputadorasPrototype()
        {
            _claveMateria = "AC-330";
            _materia = "Arquitectura de Computadoras";
            _tipo = "Teórico-Práctico";
            _modalidad = "Laboratorio";
            _cantidadPreguntas = 24;
            _porcentajeRevision = 50;
        }

        public override ExamenPrototype Clone()
        {
            return (ArquitecturaComputadorasPrototype)this.MemberwiseClone();
        }
    }
}
