using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Prototipo
{
    class Program
    {
        static void Main(string[] args)
        {  // Prototipos base
            ExamenPrototype prototipoPatrones = new PatronesDisenoPrototype();
            ExamenPrototype prototipoPOO = new ProgramacionOOPrototype();
            ExamenPrototype prototipoBD = new BaseDatosPrototype();
            ExamenPrototype prototipoRedes = new RedesPrototype();
            ExamenPrototype prototipoSO = new SistemasOperativosPrototype();
            ExamenPrototype prototipoIS = new IngenieriaSoftwarePrototype();
            ExamenPrototype prototipoCalculo = new CalculoPrototype();
            ExamenPrototype prototipoProbabilidad = new ProbabilidadPrototype();
            ExamenPrototype prototipoArquitectura = new ArquitecturaComputadorasPrototype();

            // 1) Patrones de Diseño - mismo docente, grupo A
            ExamenPrototype examen1 = prototipoPatrones.Clone();
            examen1.Docente = "Mtro. Carlos Ramírez";
            examen1.Grupo = "5A";
            examen1.Salon = "A-201";

            // 2) Patrones de Diseño - mismo docente, grupo B
            ExamenPrototype examen2 = prototipoPatrones.Clone();
            examen2.Docente = "Mtro. Carlos Ramírez";
            examen2.Grupo = "5B";
            examen2.Salon = "A-202";

            // 3) Patrones de Diseño - otro docente, grupo C
            ExamenPrototype examen3 = prototipoPatrones.Clone();
            examen3.Docente = "Dra. Laura Méndez";
            examen3.Grupo = "5C";
            examen3.Salon = "A-203";

            // 4) Programación Orientada a Objetos
            ExamenPrototype examen4 = prototipoPOO.Clone();
            examen4.Docente = "Mtro. José Torres";
            examen4.Grupo = "3A";
            examen4.Salon = "Lab-1";

            // 5) Base de Datos
            ExamenPrototype examen5 = prototipoBD.Clone();
            examen5.Docente = "Ing. Ana López";
            examen5.Grupo = "4A";
            examen5.Salon = "Lab-BD";

            // 6) Redes
            ExamenPrototype examen6 = prototipoRedes.Clone();
            examen6.Docente = "Ing. Ricardo Vega";
            examen6.Grupo = "4B";
            examen6.Salon = "R-105";

            // 7) Sistemas Operativos
            ExamenPrototype examen7 = prototipoSO.Clone();
            examen7.Docente = "Mtro. José Torres";
            examen7.Grupo = "4C";
            examen7.Salon = "Lab-SO";

            // 8) Ingeniería de Software
            ExamenPrototype examen8 = prototipoIS.Clone();
            examen8.Docente = "Dra. Laura Méndez";
            examen8.Grupo = "6A";
            examen8.Salon = "B-301";

            // 9) Cálculo Integral
            ExamenPrototype examen9 = prototipoCalculo.Clone();
            examen9.Docente = "Mtra. Elena Ruiz";
            examen9.Grupo = "2A";
            examen9.Salon = "C-102";

            // 10) Probabilidad y Estadística
            ExamenPrototype examen10 = prototipoProbabilidad.Clone();
            examen10.Docente = "Mtra. Elena Ruiz";
            examen10.Grupo = "2B";
            examen10.Salon = "C-103";

            // 11) Arquitectura de Computadoras
            ExamenPrototype examen11 = prototipoArquitectura.Clone();
            examen11.Docente = "Ing. Marco Salas";
            examen11.Grupo = "5D";
            examen11.Salon = "Lab-Arq";

            // Mostrar resultados
            MostrarExamen(examen1);
            MostrarExamen(examen2);
            MostrarExamen(examen3);
            MostrarExamen(examen4);
            MostrarExamen(examen5);
            MostrarExamen(examen6);
            MostrarExamen(examen7);
            MostrarExamen(examen8);
            MostrarExamen(examen9);
            MostrarExamen(examen10);
            MostrarExamen(examen11);

            Console.WriteLine("\n--- Ejemplo de promedio ---");
            Console.WriteLine(examen1.Promediar(new double[] { 90, 85, 100, 95 }));

            Console.ReadKey();
        }

        static void MostrarExamen(ExamenPrototype examen)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(examen.VerExamen());
            Console.WriteLine(examen.Modalidad());
            Console.WriteLine(examen.Revision());
        }
    }
}