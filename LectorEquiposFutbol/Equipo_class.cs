using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LectorEquiposFutbol
{
    class Equipo_class
    {
        Conexion_class conex = new Conexion_class();
        //const string const_sentSQL = "SELECT ID_EQUIPO, NOMBRE_EQUIPO, DIRECTOR_TECNICO FROM EQUIPOS";
        const string const_sentSQL = "SELECT * FROM EQUIPOES";
        public DataTable EnviarConsultaDatos()
        {
            return conex.Consulta(const_sentSQL);
        }

    }
}
