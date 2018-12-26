using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mapas.Dominio;
using System.Collections;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Mapas.Persistencia
{
    class GestorPuntosNegros
    {
        private ArrayList listaPuntosNegros;
        public Agente ag = new Agente();
        public OleDbDataReader dr;
        public PuntosNegros puntoNegro;

        public ArrayList listPuntosNegros
        {
            get
            {
                return listaPuntosNegros;
            }

            set
            {
                listaPuntosNegros = value;
            }
        }
        
        public GestorPuntosNegros()
        { 
           listaPuntosNegros = new ArrayList();
         }

        public void leerTodos()
        {
            ag = ag.getAgente();

            dr = ag.read("SELECT * FROM PuntosNegros");
            while (dr.Read())
            {

                puntoNegro = new PuntosNegros(dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), Int32.Parse(dr.GetValue(2).ToString()), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(5).ToString());
                MessageBox.Show(puntoNegro.ToString());
                listaPuntosNegros.Add(puntoNegro);
            }
        }

        /*
        public void leerPuntoNegro(String direccion, PuntosNegros puntoNegro) {

            ag = ag.getAgente();

            dr = ag.read("SELECT * FROM PuntosNegros WHERE Dirección = #" + direccion + "");
            while (dr.Read()) {
                
                puntoNegro.DireccionPN = dr(0);
                puntoNegro.LugarPN = dr(1);
                puntoNegro.AccidentesPN = dr(2);
                puntoNegro.SentidoPN = dr(3);
            }
        }

        public void leerTodos()
        {
            ag= ag.getAgente();

            dr = ag.read("SELECT * FROM PuntosNegros ORDER BY Lugar");
            while (dr.Read())
            {
                puntoNegro = new PuntosNegros(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5));
                listaPuntosNegros.Add(puntoNegro);
            }
        }
        */


    }
}
