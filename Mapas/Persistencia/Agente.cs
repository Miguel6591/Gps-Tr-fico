using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;



namespace Mapas.Persistencia
{
    class Agente { 

    private String CadConexion = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=";
    public OleDbConnection mConexion = new OleDbConnection();
    public Agente instancia = null;


        public void PN()
        {
            mConexion = new OleDbConnection(String.Format(CadConexion + "PuntosNegros.accdb"));
            mConexion.Open();
        }


        public void RD() {

            mConexion = new OleDbConnection(String.Format(CadConexion + "Radares.accdb"));
            mConexion.Open();
        }

        public void RT() {


            mConexion = new OleDbConnection(String.Format(CadConexion + "Retenciones.accdb"));
            mConexion.Open();

        }

        public Agente getAgente()
        {
            if (instancia == null){
                instancia = new Agente();
            }
            return instancia;
        }

        public OleDbDataReader read(String sql)
        {
            PN();
            OleDbCommand command = new OleDbCommand(sql, mConexion);
            return command.ExecuteReader();
        }

    }
}
