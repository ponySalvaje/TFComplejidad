using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.IO;

namespace TFComplejidadAlgoritmica.Entity
{
    public class Excel
    {
        public const float RadioTierraKm = 6378.0F;

        public List<Settlement> settlementsList = new List<Settlement>();
        public List<Settlement> settlementsRegionalMaincityList = new List<Settlement>();
        public List<Settlement> settlementsDistrictalMaincityList = new List<Settlement>();
        public List<Settlement> settlementsProvinceMaincityList = new List<Settlement>();
        public List<Settlement> settlementsNoMaincityList = new List<Settlement>();

        public List<Education> educationList = new List<Education>();

        public List<Education> educationListByDistrito = new List<Education>();
        public List<Education> educationListByProvincia = new List<Education>();
        public List<Education> educationListByRegion = new List<Education>();

        public Hashtable hashtableSettlement = new Hashtable();
        public Hashtable hashtableSettlementRegionalMainCity = new Hashtable();
        public Hashtable hashtableSettlementDistrictalMaincityList = new Hashtable();
        public Hashtable hashtableSettlementProvinceMaincityList = new Hashtable();
        public Hashtable hashtableSettlementNoMaincityList = new Hashtable();

        public List<Education> searchEducationList = new List<Education>();

        public int[] solucionKruskal;

        public int idCentro = 0;
        public int idEducacion = 0;

        public void ReadExcel()
        {

            string datacomplejidadalgoritmica = File.ReadAllText("C:\\Users\\marce\\Downloads\\datav2.csv");

            string datacomplejidadalgoritmicaCentrosEducativos = File.ReadAllText("C:\\Users\\marce\\Downloads\\datacentrosv2.csv");

            foreach (string fila in datacomplejidadalgoritmica.Split('\n'))
            {
                Settlement settlement = new Settlement();

                if (!string.IsNullOrEmpty(fila))
                {
                    int contador = 0;
                    settlement.Id = idCentro;
                    foreach (string valorencelda in fila.Split(';'))
                    {
                        switch (contador)
                        {
                            case 0: settlement.Code = valorencelda; break;
                            case 1: settlement.Region = valorencelda; break;
                            case 2: settlement.Province = valorencelda; break;
                            case 3: settlement.District = valorencelda; break;
                            case 4: settlement.Name = valorencelda; break;
                            case 5: settlement.IsCapital = Convert.ToInt32(valorencelda); break;
                            case 6: settlement.Longitude = Convert.ToDouble(valorencelda); break;
                            case 7: settlement.Latitude = Convert.ToDouble(valorencelda); break;
                            default: break;
                        }
                        contador++;
                    }
                    idCentro++;
                    settlementsList.Add(settlement);
                    hashtableSettlement.Add(settlement.Code, settlement);



                    switch (settlement.IsCapital)
                    {
                        case 0: settlementsNoMaincityList.Add(settlement); hashtableSettlementNoMaincityList.Add(settlement.Code, settlement); break;
                        case 1: settlementsRegionalMaincityList.Add(settlement); hashtableSettlementRegionalMainCity.Add(settlement.Code, settlement); break;
                        case 2: settlementsProvinceMaincityList.Add(settlement); hashtableSettlementProvinceMaincityList.Add(settlement.Code, settlement); break;
                        case 3: settlementsDistrictalMaincityList.Add(settlement); hashtableSettlementDistrictalMaincityList.Add(settlement.Code, settlement); break;
                        default: break;
                    }
                }
            }

            foreach (string fila in datacomplejidadalgoritmicaCentrosEducativos.Split('\n'))
            {
                Education education = new Education();

                if (!string.IsNullOrEmpty(fila))
                {
                    education.Id = idEducacion;
                    int contador = 0;
                    foreach (string valorencelda in fila.Split(';'))
                    {
                        switch (contador)
                        {
                            case 0: education.LocalCode = valorencelda; break;
                            case 1: education.LocalName = valorencelda; break;
                            case 2: education.CodeSettlement = valorencelda; break;
                            case 3: education.NameSettlement = valorencelda; break;
                            case 4: education.LongitudeE = Convert.ToDouble(valorencelda); break;
                            case 5: education.LatitudeE = Convert.ToDouble(valorencelda); break;
                            default: break;
                        }
                        contador++;

                    }
                    idEducacion++;
                    education.Settlement = (Settlement)hashtableSettlement[education.CodeSettlement];

                    educationList.Add(education);

                }
            }
        }

        public void SearchByDistrito(string distrito)
        {
            educationListByDistrito.Clear();
            Settlement aux = new Settlement();
            foreach (Education edu in educationList)
            {

                aux = (Settlement)hashtableSettlement[edu.CodeSettlement];
                if (aux != null)
                {
                    if (aux.District.Equals(distrito))
                    {
                        educationListByDistrito.Add(edu);
                    }
                }

            }
        }

        public void SearchByRegion(string region)
        {
            educationListByRegion.Clear();
            Settlement aux = new Settlement();
            foreach (Education edu in educationList)
            {

                aux = (Settlement)hashtableSettlement[edu.CodeSettlement];
                if (aux != null)
                {
                    if (aux.Region.Equals(region))
                    {
                        educationListByRegion.Add(edu);
                    }
                }

            }
        }

        public void SearchByProvincia(string provincia)
        {
            educationListByProvincia.Clear();
            Settlement aux = new Settlement();
            foreach (Education edu in educationList)
            {

                aux = (Settlement)hashtableSettlement[edu.CodeSettlement];
                if (aux != null)
                {
                    if (aux.Province.Equals(provincia))
                    {
                        educationListByProvincia.Add(edu);
                    }
                }

            }
        }

        public static double CalculaDistancia(Settlement settlement1, Settlement settlement2)
        {

            var difLatitud = Convert.ToSingle(Math.PI / 180) * (settlement2.Latitude - settlement1.Latitude);
            var difLongitud = Convert.ToSingle(Math.PI / 180) * (settlement2.Longitude - settlement1.Longitude);

            var a = Math.Pow(Math.Sin(difLatitud / 2), 2) +
                      Math.Cos(Convert.ToSingle(Math.PI / 180) * settlement1.Latitude) *
                      Math.Cos(Convert.ToSingle(Math.PI / 180) * settlement2.Latitude) *
                      Math.Pow(Math.Sin(difLongitud / 2), 2);

            return RadioTierraKm * Convert.ToSingle(2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a)));
        }

        public double[,] GenerarMatrizAdj(List<Settlement> listaCentrosPoblados)
        {
            double[,] matrizAdj = new double[listaCentrosPoblados.Count, listaCentrosPoblados.Count];
            for (int i = 0; i < listaCentrosPoblados.Count; i++)
            {
                for (int j = 0; j < listaCentrosPoblados.Count; j++)
                {
                    matrizAdj[i, j] = CalculaDistancia(listaCentrosPoblados[i], listaCentrosPoblados[j]);
                }
            }
            return matrizAdj;
        }

        //Algoritmo de Kruskall

        public struct Arista
        {
            public Settlement CentroPobladoPrimero;
            public Settlement CentroPobladoSegundo;
            public double Distancia;
            public void setearDistancia()
            {
                Distancia = CalculaDistancia(CentroPobladoPrimero, CentroPobladoSegundo);
            }
        }

        public struct Grafo
        {
            public int VerticesCount;
            public int AristasCount;
            public Arista[] aristas;
        }

        public struct Subset
        {
            public int Parent;
            public int Rank;
        }

        public static Grafo CrearGrafo(int verticesCount, int aristasCount)
        {
            Grafo grafo = new Grafo();
            grafo.VerticesCount = verticesCount;
            grafo.AristasCount = aristasCount;
            grafo.aristas = new Arista[grafo.AristasCount];
            return grafo;
        }

        private static int Find(Subset[] subsets, int i)
        {
            if (subsets[i].Parent != i)
                subsets[i].Parent = Find(subsets, subsets[i].Parent);

            return subsets[i].Parent;
        }

        private static void Union(Subset[] subsets, int x, int y)
        {
            int xroot = Find(subsets, x);
            int yroot = Find(subsets, y);

            if (subsets[xroot].Rank < subsets[yroot].Rank)
                subsets[xroot].Parent = yroot;
            else if (subsets[xroot].Rank > subsets[yroot].Rank)
                subsets[yroot].Parent = xroot;
            else
            {
                subsets[yroot].Parent = xroot;
                ++subsets[xroot].Rank;
            }
        }

        public void Print(Arista[] result, int e)
        {
            for (int i = 0; i < e; ++i)
            {
                solucionKruskal[i] = result[i].CentroPobladoPrimero.Id;
            }    
            // Console.WriteLine("{0} -- {1} == {2}", result[i].CentroPobladoPrimero.Name, result[i].CentroPobladoSegundo.Name, result[i].Distancia);
        }

        public void Kruskal(Grafo grafo)
        {
            int verticesCount = grafo.VerticesCount;
            Arista[] result = new Arista[verticesCount];
            int i = 0;
            int e = 0;

            Array.Sort(grafo.aristas, delegate (Arista a, Arista b)
            {
                a.setearDistancia();
                b.setearDistancia();
                return a.Distancia.CompareTo(b.Distancia);
            });

            Subset[] subsets = new Subset[verticesCount];

            for (int v = 0; v < verticesCount; ++v)
            {
                subsets[v].Parent = v;
                subsets[v].Rank = 0;
            }

            while (e < verticesCount - 1)
            {
                Arista nextEdge = grafo.aristas[i++];
                int x = Find(subsets, nextEdge.CentroPobladoPrimero.Id);
                int y = Find(subsets, nextEdge.CentroPobladoSegundo.Id);

                if (x != y)
                {
                    result[e++] = nextEdge;
                    Union(subsets, x, y);
                }
            }

            Print(result, e);
        }

    }
}

