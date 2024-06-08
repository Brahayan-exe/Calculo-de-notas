using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using NotasEstudiantes.Modelo;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NotasEstudiantes.Controlador
{
    internal class CEstudiantes
    {
        MEstudiantes estudiantes = new MEstudiantes();
        private string id = null;
        public DataTable MostrarEstudiantes() 
        {
            DataTable tabla = new DataTable();
            tabla = estudiantes.MostrarEstudiantes();

            return tabla;

        }

        public void InsertarEstudiantes(string Estudiante, string Nota_1, string Nota_2, string Nota_3)
        {
           estudiantes.InsertarEstudiantes(Estudiante, (float)Math.Round(Convert.ToDouble(Nota_1), 1), (float)Math.Round(Convert.ToDouble(Nota_2), 1), (float)Math.Round(Convert.ToDouble(Nota_3), 1));
         
        }

        public void EliminarEstudiante(string id) 
        {
            estudiantes.EliminarEstudiante(Convert.ToInt32(id));
        }

        public void ActualizarNota(string id,string Estudiante, string Nota_1, string Nota_2, string Nota_3) 
        {
            estudiantes.ActualizarNota(Convert.ToInt32(id),Estudiante, (float)Math.Round(Convert.ToDouble(Nota_1), 1), (float)Math.Round(Convert.ToDouble(Nota_2), 1), (float)Math.Round(Convert.ToDouble(Nota_3), 1));
        }

        public void BuscarEstudiante(string Estudiante)
        {
            estudiantes.BucarEstudiante(Estudiante);
        }
    }
}
