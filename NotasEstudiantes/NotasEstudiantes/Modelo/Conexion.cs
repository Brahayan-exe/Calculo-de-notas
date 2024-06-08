using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using Microsoft.Data.SqlClient;
using System.Data.SqlClient;


namespace NotasEstudiantes.Modelo
{
    public class Conexion
    {
         SqlConnection conexion = new SqlConnection("Server=ITHEALTH-FERNEY\\SQLEXPRESS;Database=CalculoNotas;Integrated Security=True;");

            public SqlConnection AbrirConexion()
            { 
                if (conexion.State == ConnectionState.Closed)
                conexion.Open();
                return conexion;
            }
            
            public SqlConnection CerrarConexion()
            {
            if (conexion.State == ConnectionState.Open)         
                conexion.Close();
                return conexion;
            }
    }


}
