using Mapas.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapas.Dominio
{
    class Radar
    {
        private String lugarRAD;
        private String direccionRAD;
        private String tipoRAD;
        private String sentidoRAD;
        private String limVelocidadRAD;
        private String cAutonomaRAD;
        private String provinciaRAD;
        private GestorRadares gestorRAD;


        public Radar(String lugar, String direccion, String tipo, String sentido, String limiteVelocidad, String cAutonoma, String provincia)
        {
            LugarRAD = lugar;
            DireccionRAD = direccion;
            TipoRAD = tipo;
            SentidoRAD = sentido;
            LimVelocidadRAD = limiteVelocidad;
            CAutonomaRAD = cAutonoma;
            ProvinciaRAD = provincia;

        }

        public Radar()
        {
            gestorR = new GestorRadares();
        }

        internal GestorRadares gestorR
        {
            get
            {
                return gestorRAD;
            }

            set
            {
                gestorRAD = value;
            }
        }

        public string LugarRAD
        {
            get
            {
                return lugarRAD;
            }

            set
            {
                lugarRAD = value;
            }
        }

        public string DireccionRAD
        {
            get
            {
                return direccionRAD;
            }

            set
            {
                direccionRAD = value;
            }
        }

        public string TipoRAD
        {
            get
            {
                return tipoRAD;
            }

            set
            {
                tipoRAD = value;
            }
        }

        public string SentidoRAD
        {
            get
            {
                return sentidoRAD;
            }

            set
            {
                sentidoRAD = value;
            }
        }

        public string LimVelocidadRAD
        {
            get
            {
                return limVelocidadRAD;
            }

            set
            {
                limVelocidadRAD = value;
            }
        }

        public string CAutonomaRAD
        {
            get
            {
                return cAutonomaRAD;
            }

            set
            {
                cAutonomaRAD = value;
            }
        }

        public string ProvinciaRAD
        {
            get
            {
                return provinciaRAD;
            }

            set
            {
                provinciaRAD = value;
            }
        }

       /*
        public void leerAll()
        {
            return gestorR.leerTodos();
        }

        public void leer(String direccion)
        {
            return gestorR.leerRadar(direccion);
        }*/


    }
}
