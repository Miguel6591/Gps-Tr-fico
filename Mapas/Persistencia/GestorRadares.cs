using Mapas.Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapas.Persistencia
{
    class GestorRadares
    {
        private ArrayList listaRadares;
        private ArrayList ranking;
        public Agente ag;
        public OleDbDataReader dr;
        public Radar radar;

        public ArrayList listRadares
        {
            get
            {
                return listaRadares;
            }

            set
            {
                listaRadares = value;
            }
        }

        public ArrayList listRanking
        {
            get
            {
                return ranking;
            }

            set
            {
                ranking = value;
            }
        }

        public GestorRadares()
        {
            listaRadares = new ArrayList();
        }


    }
}
