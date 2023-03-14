using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;
using Capa_Entidad;
namespace Capa_Negocio
{
    public class ClaseNegocio
    {
        ClaseDatos objd = new ClaseDatos();

        public DataTable N_user(ClaseEntidad obje)
        {
            return objd.D_user(obje);
        }
        public DataTable N_listar_carros()
        {
            return objd.D_listar_carros();
        }

        public DataTable N_buscar_carros(ClaseEntidad obje)
        {
            return objd.D_buscar_carros(obje);
        }

        public String N_mantenimiento_carros(ClaseEntidad obje)
        {
            return objd.D_mantenimiento_carros(obje);
        }

        public DataTable N_listar_clientes()
        {
            return objd.D_listar_clientes();
        }

        public DataTable N_buscar_clientes(ClaseEntidad obje)
        {
            return objd.D_buscar_clientes(obje);
        }

        public String N_mantenimiento_clientes(ClaseEntidad obje)
        {
            return objd.D_mantenimiento_clientes(obje);
        }




        public DataTable N_listar_conductor()
        {
            return objd.D_listar_clientes();
        }

        public DataTable N_buscar_conductor(ClaseEntidad obje)
        {
            return objd.D_buscar_clientes(obje);
        }

        public String N_mantenimiento_conductor(ClaseEntidad obje)
        {
            return objd.D_mantenimiento_clientes(obje);
        }




        public DataTable N_listar_paramedico()
        {
            return objd.D_listar_paramedico();
        }

        public DataTable N_buscar_paramedico(ClaseEntidad obje)
        {
            return objd.D_buscar_paramedico(obje);
        }

        public String N_mantenimiento_paramedico(ClaseEntidad obje)
        {
            return objd.D_mantenimiento_paramedico(obje);
        }


        public DataTable N_listar_reserva()
        {
            return objd.D_listar_reserva();
        }

        public DataTable N_buscar_reserva(ClaseEntidad obje)
        {
            return objd.D_buscar_reserva(obje);
        }

        public String N_mantenimiento_reserva(ClaseEntidad obje)
        {
            return objd.D_mantenimiento_reserva(obje);
        }
    }
}
