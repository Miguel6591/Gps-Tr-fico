using Mapas.Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapas.Persistencia
{
    class GestorRetenciones
    {
        private ArrayList listaRetenciones;
        public Agente ag;
        public OleDbDataReader dr;
        public Retencion retencion;

        public ArrayList listRetenciones
        {
            get
            {
                return listaRetenciones;
            }

            set
            {
                listaRetenciones = value;
            }
        }

        public GestorRetenciones()
        {
            listaRetenciones = new ArrayList();
        }


    }
}
