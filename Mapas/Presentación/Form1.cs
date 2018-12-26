using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Data.OleDb;
using Mapas.Persistencia;
using Mapas.Dominio;
using System.Globalization;
using System.Collections;

namespace Mapas
{
    public partial class Form1 : Form
    {
        GMapOverlay puntosNegrosOverlay;
        GMapOverlay radaresOverlay;
        GMapOverlay retencionesOverlay;
        GMapMarker marker;
        PuntosNegros puntoNegro= new PuntosNegros();

        public Form1()
        {
            InitializeComponent();
            // Initialize map:
            
            gmap.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmap.SetPositionByKeywords("Ciudad Real, Spain");
            puntosNegrosOverlay = new GMapOverlay("puntosNegrosOverlay");
            radaresOverlay = new GMapOverlay("radaresOverlay");
            retencionesOverlay = new GMapOverlay("retencionesOverlay");
            //gmap.Overlays.Add(markers);
            cargarPN();
            cargarRA();
            cargarRE();
            limpiarDGV();

            gmap.MinZoom = 0;
            gmap.MaxZoom = 24;
            gmap.Zoom = 9;

            trackBar1.Minimum = gmap.MinZoom * 100;
            trackBar1.Maximum = gmap.MaxZoom * 100;
            trackBar1.TickFrequency = 100;
        }


      public void generarMarkers()
        {
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(38.9554156, -3.9809874),GMarkerGoogleType.blue_pushpin);
           // markers.Markers.Add(marker);
          //  gmap.Overlays.Add(markers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarDGVPN();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarDGVRA();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargarDGVRE();
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            gmap.Overlays.Clear();
            //puntosNegrosOverlay.Markers.Clear();
            gmap.ReloadMap();
            checkBoxPN.Checked = false;
            checkBoxR.Checked = false;
            checkBoxRT.Checked = false;
        }


        public void cargarPN()
        {
            double lat;
            double lon;
            
            string strProvider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
            string strSql = " SELECT * FROM PuntosNegros";
            OleDbConnection con = new OleDbConnection(String.Format(strProvider + "PuntosNegros.accdb"));
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable puntos = new DataTable();
            da.Fill(puntos);
            DgvPuntosNegros.DataSource = puntos;
            DataRow[] result = puntos.Select();


            foreach (DataRow row in result)
            {
                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";
                provider.NumberGroupSeparator = ",";
                string[] coordenadas = (row["Direccion"].ToString()).Split(',');
                lat = Convert.ToDouble(coordenadas[0], provider);
                Console.WriteLine(lat);
                lon = Convert.ToDouble(coordenadas[1], provider);
                Console.WriteLine(lon);
                marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.blue);
                puntosNegrosOverlay.Markers.Add(marker);
                marker.ToolTipText = "Lugar: " + row["Lugar"].ToString()+ "\n" + "Número de accidentes: " + row["numAccidentes"].ToString();
                marker.ToolTip.TextPadding = new Size(10, 30);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                
            }

            gmap.Overlays.Add(puntosNegrosOverlay);
        }

        public void cargarRA()
        {
            double lat;
            double lon;

            string strProvider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
            string strSql = " SELECT * FROM Radares";
            OleDbConnection con = new OleDbConnection(String.Format(strProvider + "Radares.accdb"));
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable puntos = new DataTable();
            da.Fill(puntos);
            DgvPuntosNegros.DataSource = puntos;
            DataRow[] result = puntos.Select();

            foreach (DataRow row in result)
            {
                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";
                provider.NumberGroupSeparator = ",";
                string[] coordenadas = (row["Direccion"].ToString()).Split(',');
                lat = Convert.ToDouble(coordenadas[0], provider);
                Console.WriteLine(lat);
                lon = Convert.ToDouble(coordenadas[1], provider);
                Console.WriteLine(lon);
                marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.green);
                radaresOverlay.Markers.Add(marker);
                marker.ToolTipText = "Lugar: " + row["Lugar"].ToString() + "\n" + "Límite de velocidad: " + row["Limite Velocidad"].ToString();
                marker.ToolTip.TextPadding = new Size(10, 30);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            }

            gmap.Overlays.Add(radaresOverlay);
        }

        public void cargarRE()
        {
            double lat;
            double lon;

            string strProvider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
            string strSql = " SELECT * FROM Retenciones";
            OleDbConnection con = new OleDbConnection(String.Format(strProvider + "Retenciones.accdb"));
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable puntos = new DataTable();
            da.Fill(puntos);
            DgvPuntosNegros.DataSource = puntos;
            DataRow[] result = puntos.Select();

            foreach (DataRow row in result)
            {
                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";
                provider.NumberGroupSeparator = ",";
                string[] coordenadas = (row["Direccion"].ToString()).Split(',');
                lat = Convert.ToDouble(coordenadas[0], provider);
                Console.WriteLine(lat);
                lon = Convert.ToDouble(coordenadas[1], provider);
                Console.WriteLine(lon);
                marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.orange);
                retencionesOverlay.Markers.Add(marker);
                marker.ToolTipText = "Lugar: " + row["Lugar"].ToString() + "\n" + "Motivo: " + row["Motivo"].ToString() + "\n" + "Nivel de retención: " + row["Nivel"].ToString();
                marker.ToolTip.TextPadding = new Size(10, 30);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            }

            gmap.Overlays.Add(retencionesOverlay);
        }

        public void limpiarDGV()
        {
            DgvPuntosNegros.DataSource = null;
        }

        private void checkBoxPN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPN.Checked == true)
            {
                if (!gmap.Overlays.Contains(puntosNegrosOverlay))
                {
                    gmap.Overlays.Add(puntosNegrosOverlay);
                    gmap.ReloadMap();
                }
            }
            else
            {
                gmap.Overlays.Remove(puntosNegrosOverlay);
                gmap.ReloadMap();
            }
        }

        private void checkBoxR_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxR.Checked == true)
            {
                if (!gmap.Overlays.Contains(radaresOverlay))
                {
                    gmap.Overlays.Add(radaresOverlay);
                    gmap.ReloadMap();
                }
            }
            else
            {
                gmap.Overlays.Remove(radaresOverlay);
                gmap.ReloadMap();
            }
        }

        private void checkBoxRT_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxRT.Checked == true)
            {
                if (!gmap.Overlays.Contains(retencionesOverlay))
                {
                    gmap.Overlays.Add(retencionesOverlay);
                    gmap.ReloadMap();
                }
                
            }
            else
            {
                gmap.Overlays.Remove(retencionesOverlay);
                gmap.ReloadMap();
            }
        }

        public void cargarDGVPN()
        {
            string strProvider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
            string strSql = " SELECT * FROM PuntosNegros ORDER BY numAccidentes DESC";
            OleDbConnection con = new OleDbConnection(String.Format(strProvider + "PuntosNegros.accdb"));
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable puntos = new DataTable();
            da.Fill(puntos);
            DgvPuntosNegros.DataSource = puntos;
        }

        public void cargarDGVRA()
        {
            string strProvider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
            string strSql = " SELECT * FROM Radares ORDER BY Provincia";
            OleDbConnection con = new OleDbConnection(String.Format(strProvider + "Radares.accdb"));
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable puntos = new DataTable();
            da.Fill(puntos);
            DgvPuntosNegros.DataSource = puntos;
        }

        public void cargarDGVRE()
        {
            string strProvider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
            string strSql = " SELECT * FROM Retenciones ORDER BY nivel DESC";
            OleDbConnection con = new OleDbConnection(String.Format(strProvider + "Retenciones.accdb"));
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable puntos = new DataTable();
            da.Fill(puntos);
            DgvPuntosNegros.DataSource = puntos;
        }

        private void buttonMas_Click(object sender, EventArgs e)
        {
            gmap.Zoom = ((int)gmap.Zoom) + 1;
            trackBar1.Value = (int)(gmap.Zoom * 100.0);
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            
            gmap.Zoom = ((int)(gmap.Zoom + 0.99)) - 1;
            trackBar1.Value = (int)(gmap.Zoom * 100.0);
        }
        
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            gmap.Zoom = trackBar1.Value / 100.0;
        }
              
       
    }
}
