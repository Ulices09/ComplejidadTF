using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
namespace ComplejidadTF
{
    class Graph
    {
        private List<Arista> aristas = new List<Arista>();
        private double pesoActual;
        private int estado;
        private int[] distBellmanFord;
        private int v;

        public Graph(int v)
        {
            this.v = v;
            pesoActual = 0;
            estado = Estados.NO_COMPLETADO;
            distBellmanFord = new int[v];
        }

        internal List<Arista> Aristas
        {
            get { return aristas; }
            set { aristas = value; }
        }
        public double PesoActual
        {
            get { return pesoActual; }
            set { pesoActual = value; }
        }
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public void addArista(Nodo origen, Nodo destino)
        {
            aristas.Add(new Arista(origen, destino));
        }

        public void Mostrar(Graphics gr)
        {
            foreach (Arista arista in aristas)
            {
                arista.Mostrar(gr);
            }
        }
        public void MostrarBellman(Graphics gr)
        {
            foreach (Arista arista in aristas)
            {
                arista.MostrarBellman(gr);
            }
        }

        public void ResetearAristas()
        {
            foreach (Arista arista in aristas)
                arista.Estado = Estados.NORMAL;
        }

        private Nodo ObtenerOrigen()
        {
            Arista arista = aristas.Find(x => x.Origen.Valor == 0 || x.Destino.Valor == 0);
            return (arista.Origen.Valor == 0) ? arista.Origen : arista.Destino;
        }

        public string BellmanFord()
        {
            Nodo nodoOrigen = ObtenerOrigen();

            for (int i = 0; i < v; i++)
                distBellmanFord[i] = Int32.MaxValue;

            distBellmanFord[nodoOrigen.Valor] = 0;

            for (int i = 0; i < v-1; i++)
            {
                foreach (Arista arista in aristas)
                {
                    int origen = arista.Origen.Valor;
                    int destino = arista.Destino.Valor;
                    int peso =  Convert.ToInt32(arista.Peso);

                    if (distBellmanFord[origen] != Int32.MaxValue && distBellmanFord[origen] + peso < distBellmanFord[destino])
                        distBellmanFord[destino] = distBellmanFord[origen] + peso;
                }
            }

            for (int i = 0; i < v - 1; i++)
            {
                foreach (Arista arista in aristas)
                {
                    int origen = arista.Origen.Valor;
                    int destino = arista.Destino.Valor;
                    int peso = Convert.ToInt32(arista.Peso);

                    if (distBellmanFord[origen] != Int32.MaxValue && distBellmanFord[origen] + peso < distBellmanFord[destino])
                        return "Existen Ciclos Negativos";
                }
            }
            string mensaje = "";
            for (int i = 0; i < v; i++)
                mensaje += ObtenerLetraNodo(i) + "    costo: " +distBellmanFord[i].ToString() + "\n";

            return mensaje;
        }

        public string ObtenerLetraNodo(int valor)
        {
            Arista arista = aristas.Find(x => x.Origen.Valor == valor || x.Destino.Valor == valor);
            return (arista.Origen.Valor == valor) ? arista.Origen.Letra : arista.Destino.Letra;
        }

        public int ObtenerPesoOriginADestino()
        {
            return distBellmanFord[v - 1];
        }

        public double KruskalMST(int action){
	        double mst_wt = 0;
            aristas = aristas.OrderBy(x => x.Peso).ToList();
            DisjointSet ds = new DisjointSet(v);

            foreach (Arista arista in aristas)
            {
                int origen = arista.Origen.Valor;
                int destino = arista.Destino.Valor;
                double peso = arista.Peso;
                int set_origen = ds.FindSet(origen);
                int set_destino = ds.FindSet(destino);

                if (set_origen != set_destino)
                {
                    if(action == 1)
                        arista.Estado = Estados.OPTIMO;

                    ds.UnionSet(set_origen, set_destino);
                    mst_wt += peso;
                }
            }
	        return mst_wt;
        }

        public double SeleccionarNodo(int x, int y)
        {
            foreach (Arista arista in aristas)
            {
                if (arista.Origen.Estado == Estados.SELECCIONADO)
                {
                    int _x = arista.Destino.X;
                    int _y = arista.Destino.Y;
                    int _radio = arista.Destino.Radio;
                    if((x >= _x && x < _x + _radio * 4) && (y >= _y && y < _y + _radio * 4))
                    {

                        pesoActual += arista.Peso;

                        if (arista.Destino.Estado == Estados.DESTINO)
                        {
                            estado = Estados.COMPLETADO;
                        }

                        arista.Origen.Estado = Estados.NO_SELECCIONADO;
                        arista.Destino.Estado = Estados.SELECCIONADO;

                        return pesoActual;
                    }
                }
                else if (arista.Destino.Estado == Estados.SELECCIONADO)
                {
                    int _x = arista.Origen.X;
                    int _y = arista.Origen.Y;
                    int _radio = arista.Origen.Radio;
                    if ((x >= _x && x < _x + _radio * 4) && (y >= _y && y < _y + _radio * 4))
                    {
                        pesoActual += arista.Peso;

                        if (arista.Origen.Estado == Estados.DESTINO)
                        {
                            estado = Estados.COMPLETADO;
                        }

                        arista.Destino.Estado = Estados.NO_SELECCIONADO;
                        arista.Origen.Estado = Estados.SELECCIONADO;
                        return pesoActual;
                    }
                }
            }
            return pesoActual;
        }
    }
}