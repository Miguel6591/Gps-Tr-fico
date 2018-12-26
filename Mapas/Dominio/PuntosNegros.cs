using Mapas.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapas.Dominio
{
    class PuntosNegros
    {
        private String lugarPN;
        private String direccionPN;
        private int accidentesPN;
        private String sentidoPN;
        private String cAutonomiaPN;
        private String provinciaPN;
        private GestorPuntosNegros puntosNegros;

        public PuntosNegros(String lugar, String direccion, int accidentes, String sentido, String cAutonoma, String provincia)
        {
            lugarPN = lugar;
            direccionPN = direccion;
            accidentesPN = accidentes;
            sentidoPN = sentido;
            cAutonomiaPN = cAutonoma;
            provinciaPN = provincia;
        }

        public PuntosNegros(){
            gestorPN = new GestorPuntosNegros();
        }

        public string LugarPN
        {
            get
            {
                return lugarPN;
            }

            set
            {
                lugarPN = value;
            }
        }

        public string DireccionPN
        {
            get
            {
                return direccionPN;
            }

            set
            {
                direccionPN = value;
            }
        }

        public int AccidentesPN
        {
            get
            {
                return accidentesPN;
            }

            set
            {
                accidentesPN = value;
            }
        }

        public string SentidoPN
        {
            get
            {
                return sentidoPN;
            }

            set
            {
                sentidoPN = value;
            }
        }

        public string CAutonomiaPN
        {
            get
            {
                return cAutonomiaPN;
            }

            set
            {
                cAutonomiaPN = value;
            }
        }

        public string ProvinciaPN
        {
            get
            {
                return provinciaPN;
            }

            set
            {
                provinciaPN = value;
            }
        }

        internal GestorPuntosNegros gestorPN
        {
            get
            {
                return puntosNegros;
            }

            set
            {
                puntosNegros = value;
            }
        }

        public void leerAll() {
            gestorPN.leerTodos();
        }

       /* public void leer(String direccion ) {
            gestorPN.leerPuntoNegro(direccion);
        }*/



    }


}
