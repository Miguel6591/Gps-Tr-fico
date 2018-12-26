using Mapas.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapas.Dominio
{
    class Retencion
    {
        private String lugarRET;
        private String direccionRET;
        private String motivoRET;
        private int nivelRET;
        private String SentidoRET;
        private String CAutonomaRET;
        private String ProvinciaRET;
        private GestorRetenciones mgestor;

        public Retencion(String lugar, String direccion, String motivo, int nivel, String sentido, String cAutonoma, String provincia)
        {
            lugarRET = lugar;
            direccionRET = direccion;
            MotivoRET = motivo;
            nivelRET = nivel;
            SentidoRET = sentido;
            CAutonomaRET = cAutonoma;
            ProvinciaRET = provincia;

        }

        public Retencion()
        {
            gestorRT = new GestorRetenciones();
        }


        internal GestorRetenciones gestorRT
        {
            get
            {
                return mgestor;
            }

            set
            {
                mgestor = value;
            }
        }

        public string LugarRET
        {
            get
            {
                return lugarRET;
            }

            set
            {
                lugarRET = value;
            }
        }

        public string DireccionRET
        {
            get
            {
                return direccionRET;
            }

            set
            {
                direccionRET = value;
            }
        }

        public string MotivoRET
        {
            get
            {
                return motivoRET;
            }

            set
            {
                motivoRET = value;
            }
        }

        public int NivelRET
        {
            get
            {
                return nivelRET;
            }

            set
            {
                nivelRET = value;
            }
        }

        public string SentidoRET1
        {
            get
            {
                return SentidoRET;
            }

            set
            {
                SentidoRET = value;
            }
        }

        public string CAutonomaRET1
        {
            get
            {
                return CAutonomaRET;
            }

            set
            {
                CAutonomaRET = value;
            }
        }

        public string ProvinciaRET1
        {
            get
            {
                return ProvinciaRET;
            }

            set
            {
                ProvinciaRET = value;
            }
        }

/*    

        public void leerAll()
        {
            return gestorRT.leerTodos();
        }

        public void leer(String direccion)
        {
            return gestorRT.leerRetenciones(direccion);
        }
        */
    }
}
