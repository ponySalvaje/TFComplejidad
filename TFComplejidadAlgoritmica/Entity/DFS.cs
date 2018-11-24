using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFComplejidadAlgoritmica.Entity
{
    public class DFS
    {
        public List<int> caminoDFS = new List<int>();
        public int[] centrosVisitados;
        public int N;
        public double[,] Grafo;

        public DFS(double[,] grafo, int n, int nodoOrigen)
        {
            Grafo = grafo;
            N = n;
            centrosVisitados = new int[N];
            for(int i = 0; i < N; i++)
            {
                centrosVisitados[i] = 0;
            }
            DFSUtil(nodoOrigen);
            //regresa al punto de retorno
            caminoDFS.Add(nodoOrigen);
        }

        public void DFSUtil(int nodoActual)
        {
            caminoDFS.Add(nodoActual);
            centrosVisitados[nodoActual] = 1;
            for(int i = 0; i < N; i++)
            {
                if(centrosVisitados[i] == 0 && Grafo[nodoActual, i] == 1)
                {
                    DFSUtil(i);
                }
            }
        }
    }
}
