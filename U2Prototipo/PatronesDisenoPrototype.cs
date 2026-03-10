using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Prototipo
{
    public class PatronesDisenoPrototype : ExamenPrototype
    {
        public PatronesDisenoPrototype()
        {
            _claveMateria = "DSC-401";
            _materia = "Patrones de Diseño";
            _tipo = "Teórico-Práctico";
            _modalidad = "Presencial";
            _cantidadPreguntas = 20;
            _porcentajeRevision = 50;
        }

        public override ExamenPrototype Clone()
        {
            return (PatronesDisenoPrototype)this.MemberwiseClone();
        }

        public override string VerExamen()
        {
            return $"[Patrones de Diseño] Clave: {_claveMateria}, Docente: {_docente}, " +
                   $"Grupo: {_grupo}, Salón: {_salon}, Tipo: {_tipo}, Preguntas: {_cantidadPreguntas}";
        }
    }
}
