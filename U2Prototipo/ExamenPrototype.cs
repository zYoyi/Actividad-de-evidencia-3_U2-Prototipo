using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Prototipo
{
    public abstract class ExamenPrototype
    {
        // Datos protegidos
        protected string _claveMateria;
        protected string _materia;
        protected string _docente;
        protected string _grupo;
        protected string _salon;
        protected string _tipo;
        protected string _modalidad;
        protected int _cantidadPreguntas;
        protected double _porcentajeRevision;

        // Propiedades públicas
        public string ClaveMateria { get => _claveMateria; set => _claveMateria = value; }
        public string Materia { get => _materia; set => _materia = value; }
        public string Docente { get => _docente; set => _docente = value; }
        public string Grupo { get => _grupo; set => _grupo = value; }
        public string Salon { get => _salon; set => _salon = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string ModalidadExamen { get => _modalidad; set => _modalidad = value; }
        public int CantidadPreguntas { get => _cantidadPreguntas; set => _cantidadPreguntas = value; }
        public double PorcentajeRevision { get => _porcentajeRevision; set => _porcentajeRevision = value; }

        public abstract ExamenPrototype Clone();

        public virtual string Modalidad()
        {
            return $"La modalidad del examen es: {_modalidad}";
        }

        public virtual string Revision()
        {
            return $"El examen tiene revisión del {_porcentajeRevision}%";
        }

        public virtual string Promediar(double[] calificaciones)
        {
            if (calificaciones == null || calificaciones.Length == 0)
                return "No hay calificaciones para promediar.";

            double suma = 0;
            foreach (double cal in calificaciones)
            {
                suma += cal;
            }

            double promedio = suma / calificaciones.Length;
            return $"Promedio del examen: {promedio:F2}";
        }

        public virtual string VerExamen()
        {
            return $"Materia: {_materia} | Clave: {_claveMateria} | Docente: {_docente} | " +
                   $"Grupo: {_grupo} | Salón: {_salon} | Tipo: {_tipo} | " +
                   $"Preguntas: {_cantidadPreguntas}";
        }
    }
}