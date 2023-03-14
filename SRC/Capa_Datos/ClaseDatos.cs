using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;
namespace Capa_Datos
{
    public class ClaseDatos
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_user(ClaseEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("sp_logueo_ez", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@clave", obje.clave);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_listar_carros()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_carros", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_buscar_carros(ClaseEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_carros", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@placa", obje.placa);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public String D_mantenimiento_carros(ClaseEntidad obje)
        {
            String accion = "";
            try
            {
                SqlCommand cmd = new SqlCommand("sp_mantenimiento_carros", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", obje.codigo);
            cmd.Parameters.AddWithValue("@marca", obje.marca);
            cmd.Parameters.AddWithValue("@modelo", obje.modelo);
            cmd.Parameters.AddWithValue("@placa", obje.placa);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
            }
            catch (SqlException ex)
            {
                // Controlar la excepción de SQL Server
                accion = "Error al ejecutar el procedimiento almacenado: " + ex.Message;
            }
            catch (Exception ex)
            {
                // Controlar cualquier otra excepción
                accion = "Error inesperado: " + ex.Message;
            }
            return accion;

        }

        public DataTable D_listar_clientes()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_clientes", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_buscar_clientes(ClaseEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_clientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", obje.cedula);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public String D_mantenimiento_clientes(ClaseEntidad obje)
        {
            String accion = "";
            try { 
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_clientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", obje.codigo2);
            cmd.Parameters.AddWithValue("@nombres", obje.nombres);
            cmd.Parameters.AddWithValue("@cedula", obje.cedula);
            cmd.Parameters.AddWithValue("@telefono", obje.telefono);
            cmd.Parameters.AddWithValue("@cbancaria", obje.cbancaria);
            cmd.Parameters.AddWithValue("@fnacimiento", obje.fnacimiento);
            cmd.Parameters.AddWithValue("@direccion", obje.direccion);
            cmd.Parameters.AddWithValue("@estado", obje.estado);
            cmd.Parameters.AddWithValue("@servicios", obje.servicios);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion2;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }
    catch (SqlException ex)
    {
        // Controlar la excepción de SQL Server
        accion = "Error al ejecutar el procedimiento almacenado: " + ex.Message;
    }
    catch (Exception ex)
    {
        // Controlar cualquier otra excepción
        accion = "Error inesperado: " + ex.Message;
    }
return accion;

        }


        public DataTable D_listar_conductor()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_conductor", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_buscar_conductor(ClaseEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_conductor", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", obje.cedula);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public String D_mantenimiento_conductor(ClaseEntidad obje)
        {

            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_conductor", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", obje.codigo3);
            cmd.Parameters.AddWithValue("@nombres", obje.nombres3);
            cmd.Parameters.AddWithValue("@cedula", obje.cedula3);
            cmd.Parameters.AddWithValue("@telefono", obje.telefono3);
            cmd.Parameters.AddWithValue("@dialibre", obje.dialibre3);
            cmd.Parameters.AddWithValue("@fnacimiento", obje.fnacimiento3);
            cmd.Parameters.AddWithValue("@direccion", obje.direccion3);
            cmd.Parameters.AddWithValue("@estado", obje.estado3);
            cmd.Parameters.AddWithValue("@servicios", obje.servicios3);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion3;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;

        }



        public DataTable D_listar_paramedico()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_paramedico", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_buscar_paramedico(ClaseEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_paramedico", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", obje.cedula);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public String D_mantenimiento_paramedico(ClaseEntidad obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_paramedico", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", obje.codigo4);
            cmd.Parameters.AddWithValue("@nombres", obje.nombres4);
            cmd.Parameters.AddWithValue("@cedula", obje.cedula4);
            cmd.Parameters.AddWithValue("@telefono", obje.telefono4);
            cmd.Parameters.AddWithValue("@email", obje.email4);
            cmd.Parameters.AddWithValue("@fnacimiento", obje.fnacimiento4);
            cmd.Parameters.AddWithValue("@direccion", obje.direccion4);
            cmd.Parameters.AddWithValue("@estado", obje.estado4);
            cmd.Parameters.AddWithValue("@servicios", obje.servicios4);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion4;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;

        }

        public DataTable D_listar_reserva()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_reserva", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_reserva(ClaseEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_reserva", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cliente", obje.cliente);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public String D_mantenimiento_reserva(ClaseEntidad obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_reserva", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", obje.codigo5);
            cmd.Parameters.AddWithValue("@cliente", obje.cliente);
            cmd.Parameters.AddWithValue("@conductor", obje.conductor);
            cmd.Parameters.AddWithValue("@paramedico", obje.paramedico);
            cmd.Parameters.AddWithValue("@ambulancia", obje.ambulancia);
            cmd.Parameters.AddWithValue("@fecha", obje.fecha);
            cmd.Parameters.AddWithValue("@direccion", obje.direccion5);
            cmd.Parameters.AddWithValue("@estado", obje.estado5);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion4;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;

        }
    }
}
