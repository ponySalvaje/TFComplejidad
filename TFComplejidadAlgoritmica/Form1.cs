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
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using TFComplejidadAlgoritmica.Entity;

namespace TFComplejidadAlgoritmica
{
    public partial class Form1 : Form
    {
        GMapOverlay mapa;
        GMarkerGoogle marker;
        Excel excel = new Excel();

        List<Settlement> settlementsList;
        List<Education> educationList;
        List<Settlement> settlementsRegionalMaincityList;
        List<Settlement> settlementsDistrictalMaincityList;
        List<Settlement> settlementsProvinceMaincityList;
        List<Settlement> settlementsNoMaincityList;

        double[,] matrizCapitalesRegionales;

        GMapOverlay miRuta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            excel.ReadExcel();

            settlementsList = excel.settlementsList;
            settlementsRegionalMaincityList = excel.settlementsRegionalMaincityList;
            settlementsDistrictalMaincityList = excel.settlementsDistrictalMaincityList;
            settlementsProvinceMaincityList = excel.settlementsProvinceMaincityList;
            settlementsNoMaincityList = excel.settlementsNoMaincityList;
            educationList = excel.educationList;
            

            //permite arrastrar el mapa
            mapaFormulario.DragButton = MouseButtons.Left;
            
            mapaFormulario.CanDragMap = true;
            mapaFormulario.MapProvider = GMapProviders.GoogleMap;
            mapaFormulario.Position = new PointLatLng(-12.0880376, -77.0514409);
            mapaFormulario.MinZoom = 0;
            mapaFormulario.MaxZoom = 24;
            mapaFormulario.Zoom = 5;
            mapaFormulario.AutoScroll = true;


            mapa = new GMapOverlay("marcador");
            
            
        }

        private void btnFiltrarTodosCentrosPoblados_Click(object sender, EventArgs e)
        {
            mapaFormulario.Overlays.Remove(mapa);

            List<PointLatLng> puntos = new List<PointLatLng>();
            mapa = new GMapOverlay("centropoblado");

            foreach (Settlement settlement in settlementsList)
            {
                PointLatLng mipunto = new PointLatLng(settlement.Latitude, settlement.Longitude);
                GMarkerGoogle marcadorGoogle = new GMarkerGoogle(mipunto, GMarkerGoogleType.blue);

                mapa.Markers.Add(marcadorGoogle);
            }
            mapaFormulario.Overlays.Add(mapa);
            mapaFormulario.Zoom =10;
            mapaFormulario.Zoom = mapaFormulario.Zoom + 10;
            mapaFormulario.Zoom = mapaFormulario.Zoom - 10;

            dgvLista.DataSource = settlementsList;
        }

        private void btnFiltrarCentrosPobladosCapitalesRegion_Click(object sender, EventArgs e)
        {
            mapaFormulario.Overlays.Remove(mapa);

            List<PointLatLng> puntos = new List<PointLatLng>();
            mapa = new GMapOverlay("centropoblado");

            foreach (Settlement settlement in settlementsRegionalMaincityList)
            {
                PointLatLng mipunto = new PointLatLng(settlement.Latitude, settlement.Longitude);
                GMarkerGoogle marcadorGoogle = new GMarkerGoogle(mipunto, GMarkerGoogleType.blue);

                mapa.Markers.Add(marcadorGoogle);
            }
            mapaFormulario.Overlays.Add(mapa);
            mapaFormulario.Zoom = 5;
            mapaFormulario.Zoom = mapaFormulario.Zoom + 5;
            mapaFormulario.Zoom = mapaFormulario.Zoom - 5;

            miRuta = new GMapOverlay("ruta tsp");
            miRuta.Clear();

            matrizCapitalesRegionales = excel.GenerarMatrizAdj(settlementsRegionalMaincityList);

            //fase de implementación
            //profe no nos jale

            dgvLista.DataSource = settlementsRegionalMaincityList;
        }

        private void btnFiltrarCentrosPobladosCapitalesProvincia_Click(object sender, EventArgs e)
        {
            mapaFormulario.Overlays.Remove(mapa);

            List<PointLatLng> puntos = new List<PointLatLng>();
            mapa = new GMapOverlay("centropoblado");

            foreach (Settlement settlement in settlementsProvinceMaincityList)
            {
                PointLatLng mipunto = new PointLatLng(settlement.Latitude, settlement.Longitude);
                GMarkerGoogle marcadorGoogle = new GMarkerGoogle(mipunto, GMarkerGoogleType.blue);

                mapa.Markers.Add(marcadorGoogle);
            }
            mapaFormulario.Overlays.Add(mapa);
            mapaFormulario.Zoom = 5;
            mapaFormulario.Zoom = mapaFormulario.Zoom + 2;
            mapaFormulario.Zoom = mapaFormulario.Zoom - 2;

            dgvLista.DataSource = settlementsProvinceMaincityList;
        }

        private void btnFiltrarCentrosPobladosCapitalesDistrito_Click(object sender, EventArgs e)
        {
            mapaFormulario.Overlays.Remove(mapa);

            List<PointLatLng> puntos = new List<PointLatLng>();
            mapa = new GMapOverlay("centropoblado");

            foreach (Settlement settlement in settlementsDistrictalMaincityList)
            {
                PointLatLng mipunto = new PointLatLng(settlement.Latitude, settlement.Longitude);
                GMarkerGoogle marcadorGoogle = new GMarkerGoogle(mipunto, GMarkerGoogleType.blue);

                mapa.Markers.Add(marcadorGoogle);
            }
            mapaFormulario.Overlays.Add(mapa);
            mapaFormulario.Zoom = 13;
            mapaFormulario.Zoom = mapaFormulario.Zoom + 3;
            mapaFormulario.Zoom = mapaFormulario.Zoom - 3;

            dgvLista.DataSource = settlementsDistrictalMaincityList;
        }

        private void btnFiltrarCentrosPobladosNoCapitales_Click(object sender, EventArgs e)
        {
            mapaFormulario.Overlays.Remove(mapa);

            List<PointLatLng> puntos = new List<PointLatLng>();
            mapa = new GMapOverlay("centropoblado");

            foreach (Settlement settlement in settlementsNoMaincityList)
            {
                PointLatLng mipunto = new PointLatLng(settlement.Latitude, settlement.Longitude);
                GMarkerGoogle marcadorGoogle = new GMarkerGoogle(mipunto, GMarkerGoogleType.blue);

                mapa.Markers.Add(marcadorGoogle);
            }
            mapaFormulario.Overlays.Add(mapa);
            mapaFormulario.Zoom = 13;
            mapaFormulario.Zoom = mapaFormulario.Zoom + 3;
            mapaFormulario.Zoom = mapaFormulario.Zoom - 3;

            dgvLista.DataSource = settlementsNoMaincityList;
        }

        private void btnFiltrarCentrosEducativos_Click(object sender, EventArgs e)
        {

            mapaFormulario.Overlays.Remove(mapa);

            List<PointLatLng> puntos = new List<PointLatLng>();
            mapa = new GMapOverlay("centroeducativo");

            foreach (Education education in educationList)
            {
                PointLatLng mipunto = new PointLatLng(education.LatitudeE, education.LongitudeE);
                GMarkerGoogle marcadorGoogle = new GMarkerGoogle(mipunto, GMarkerGoogleType.blue);

                mapa.Markers.Add(marcadorGoogle);
            }
            mapaFormulario.Overlays.Add(mapa);
            mapaFormulario.Zoom = 6;
            mapaFormulario.Zoom = mapaFormulario.Zoom + 6;
            mapaFormulario.Zoom = mapaFormulario.Zoom - 6;

            dgvLista.DataSource = educationList;
        }

        private void btnFiltrarCentrosEducativosPorDistrito_Click(object sender, EventArgs e)
        {
            excel.SearchByDistrito(txtDistrito.Text.ToString().ToUpper());
            mapaFormulario.Overlays.Remove(mapa);

            List<PointLatLng> puntos = new List<PointLatLng>();
            mapa = new GMapOverlay("centroeducativo");

            foreach (Education education in excel.educationListByDistrito)
            {
                PointLatLng mipunto = new PointLatLng(education.LatitudeE, education.LongitudeE);
                GMarkerGoogle marcadorGoogle = new GMarkerGoogle(mipunto, GMarkerGoogleType.blue);

                mapa.Markers.Add(marcadorGoogle);
            }

            mapaFormulario.Overlays.Add(mapa);
            mapaFormulario.Zoom = 6;
            mapaFormulario.Zoom = mapaFormulario.Zoom + 6;
            mapaFormulario.Zoom = mapaFormulario.Zoom - 6;

            dgvLista.DataSource = excel.educationListByDistrito;
            dgvLista.Columns[7].Visible = false;
        }

        private void btnFiltrarCentrosEducativosPorRegion_Click(object sender, EventArgs e)
        {
            excel.SearchByRegion(txtRegion.Text.ToString().ToUpper());
            mapaFormulario.Overlays.Remove(mapa);

            List<PointLatLng> puntos = new List<PointLatLng>();
            mapa = new GMapOverlay("centroeducativo");

            foreach (Education education in excel.educationListByRegion)
            {
                PointLatLng mipunto = new PointLatLng(education.LatitudeE, education.LongitudeE);
                GMarkerGoogle marcadorGoogle = new GMarkerGoogle(mipunto, GMarkerGoogleType.blue);

                mapa.Markers.Add(marcadorGoogle);
            }

            mapaFormulario.Overlays.Add(mapa);
            mapaFormulario.Zoom = 6;
            mapaFormulario.Zoom = mapaFormulario.Zoom + 6;
            mapaFormulario.Zoom = mapaFormulario.Zoom - 6;

            dgvLista.DataSource = excel.educationListByRegion;
            dgvLista.Columns[7].Visible = false;
        }

        private void btnFiltrarCentrosEducativosPorProvincia_Click(object sender, EventArgs e)
        {
            excel.SearchByProvincia(txtProvincia.Text.ToString().ToUpper());
            mapaFormulario.Overlays.Remove(mapa);

            List<PointLatLng> puntos = new List<PointLatLng>();
            mapa = new GMapOverlay("centroeducativo");

            foreach (Education education in excel.educationListByProvincia)
            {
                PointLatLng mipunto = new PointLatLng(education.LatitudeE, education.LongitudeE);
                GMarkerGoogle marcadorGoogle = new GMarkerGoogle(mipunto, GMarkerGoogleType.blue);

                mapa.Markers.Add(marcadorGoogle);
            }

            mapaFormulario.Overlays.Add(mapa);
            mapaFormulario.Zoom = 6;
            mapaFormulario.Zoom = mapaFormulario.Zoom + 6;
            mapaFormulario.Zoom = mapaFormulario.Zoom - 6;

            dgvLista.DataSource = excel.educationListByProvincia;
            dgvLista.Columns[7].Visible = false;
        }
    }
}
