using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Prototipo
{
    public class SistemasOperativosPrototype : ExamenPrototype
    {
        public SistemasOperativosPrototype()
        {
            _claveMateria = "SO-310";
            _materia = "Sistemas Operativos";
            _tipo = "Práctico";
            _modalidad = "Laboratorio";
            _cantidadPreguntas = 18;
            _porcentajeRevision = 50;
        }

        public override ExamenPrototype Clone()
        {
            return (SistemasOperativosPrototype)this.MemberwiseClone();
        }
    }
}
