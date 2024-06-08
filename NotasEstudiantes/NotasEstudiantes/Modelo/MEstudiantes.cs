using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Identity.Client.NativeInterop;
using NotasEstudiantes.Controlador;

namespace NotasEstudiantes.Modelo
{
    internal class MEstudiantes
    {
        Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable MostrarEstudiantes()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEstudiantes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarEstudiantes(string Estudiante, float Nota_1, float Nota_2, float Nota_3) 
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarEstudiantes";

            /*
                create proc InsertarEstudiantes
                @Estudiante varchar(50),
                @Nota_1 float,
                @Nota_2 float,
                @Nota_3 float
                as
                insert into estudiantes (Estudiante,Nota_1,Nota_2,Nota_3) values(@Estudiante,@Nota_1,@Nota_2,@Nota_3)
                update estudiantes
                SET Definitiva = @Nota_1*0.35 + @Nota_2*0.35 + @Nota_3*0.3
                where Estudiante = @Estudiante;
             */

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Estudiante", Estudiante);
            comando.Parameters.AddWithValue("@Nota_1", Nota_1);
            comando.Parameters.AddWithValue("@Nota_2", Nota_2);
            comando.Parameters.AddWithValue("@Nota_3", Nota_3);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EliminarEstudiante(int id) 
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarEstudiante";
            comando.CommandType= CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery() ;
            comando.Parameters.Clear();

        }

        public void ActualizarNota(int id, string Estudiante, float Nota_1, float Nota_2, float Nota_3) 
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarNota";
            /*
             Create proc ActualizarNota
                @id int,
                @Estudiante varchar(50),
                @Nota_1 float,
                @Nota_2 float,
                @Nota_3 float
                as
                Update estudiantes set 
                Nota_1 = @Nota_1,
                Nota_2 = @Nota_2,
                Nota_3 = @Nota_3,
                Definitiva = @Nota_1*0.35 + @Nota_2*0.35 + @Nota_3*0.3
                where id = @id;
             */
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@Estudiante", Estudiante);
            comando.Parameters.AddWithValue("@Nota_1", Nota_1);
            comando.Parameters.AddWithValue("@Nota_2", Nota_2);
            comando.Parameters.AddWithValue("@Nota_3", Nota_3);

            comando.ExecuteNonQuery() ;
            comando.Parameters.Clear();

        }

        public void BucarEstudiante(string Estudiante) 
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BucarEstudiantes";
            /*
             Create proc BucarEstudiantes
            @Estudiante varchar(50)
            as select * from estudiantes where Estudiante = @Estudiante;
             */
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Estudiante", Estudiante);
            
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

    }
}
