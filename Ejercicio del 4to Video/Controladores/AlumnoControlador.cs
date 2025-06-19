using Ejercicio_del_4to_Video.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_del_4to_Video.Controladores
{
    internal class AlumnoControlador
    {
        //Areglo de alumnos
        private Alumnos[] alumnos = new Alumnos[100];
        private int contador = 0;

        // Método para agregar un alumno

        public Alumnos[] ListarTodo()
        {
            return alumnos;
        }

        //Registro de alumnos
        public void Registrar(Alumnos alumno)
        {
            alumnos[contador] = alumno;
            contador++;
        }

        // Eliminar un alumno de arreglo
        public void Eliminar(string codigo)
        {
            int posicion = Array.FindIndex(alumnos, alumno => alumno.Codigo == codigo);

            // logica de eliminar un alumno

            for (int i = 0; i < contador; i++)
            {
                if (i >= posicion)

                {
                    alumnos[i] = alumnos[i + 1];
                }
            }

            contador--;
        }
        // metodo comparacion
        private class MetodoComparacion : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                if(((Alumnos)x).Promedio < ((Alumnos)y).Promedio) return -1; // ordenar de forma ascendente
                else if (((Alumnos)x).Promedio == ((Alumnos)y).Promedio) return 0;
                else return 1;

            }
        }
        // Ordenar alumnos por promedio
        public Alumnos[] OrdenarPorPromedio()
        {
            Array.Sort(alumnos, 0, contador, new MetodoComparacion());
            return alumnos;
        }

        // Buscar un alumno por codigo
        public Alumnos[] BuscarPorCodigo(string codigo)
        {
          return Array.FindAll(alumnos, alumno => alumno != null && alumno.Codigo.Contains(codigo));
        }

    }

}


     