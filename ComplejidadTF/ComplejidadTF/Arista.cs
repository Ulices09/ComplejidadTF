using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ComplejidadTF
{
    class Arista
    {
        private Nodo origen;
        private Nodo destino;
        private double peso;
        private int estado;
        public Arista(Nodo origen, Nodo destino)
        {
            estado = Estados.NORMAL;
            this.origen = origen;
            this.destino = destino;
            int x = Math.Abs(destino.X - origen.X);
            int y = Math.Abs(destino.Y - origen.Y);
            double sqrt = x * x + y * y;
            peso = Math.Sqrt(sqrt);
            peso = Math.Round(peso, 0);
        }
        public Nodo Origen
        {
            get { return origen; }
            set { origen = value; }
        }        

        public Nodo Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public void Mostrar(Graphics gr)
        {
            
            Color clr = Color.Aqua;
            int ancho_linea = 2;
            if (estado == Estados.OPTIMO)
            {
                Random r = new Random();
                clr = ColorTranslator.FromWin32(r.Next());
                ancho_linea = 6;
            }

            Pen Linea= new Pen(clr, ancho_linea);
            
            gr.DrawLine(Linea, origen.X + origen.Radio, origen.Y + origen.Radio, destino.X + destino.Radio, destino.Y + destino.Radio);
            origen.Mostrar(gr);
            destino.Mostrar(gr);
            int xh = origen.X +(destino.X - origen.X) / 2;
            int yh = origen.Y + (destino.Y - origen.Y) / 2;
            gr.DrawString(peso.ToString(), new Font(new FontFamily("Arial"), 10, FontStyle.Bold), Brushes.Blue, xh, yh);
        }
        public void MostrarBellman(Graphics gr)
        {

            Color clr = Color.Aqua;
            int ancho_linea = 2;
            if (estado == Estados.OPTIMO)
            {
                Random r = new Random();
                clr = ColorTranslator.FromWin32(r.Next());
                ancho_linea = 6;
            }

            Pen Flecha = new Pen(clr, ancho_linea);
            GraphicsPath capPath = new GraphicsPath();
            capPath.AddLine(-4, -14, 0, -6);
            capPath.AddLine(4, -14, 0, -6);
            Flecha.CustomEndCap = new System.Drawing.Drawing2D.CustomLineCap(null, capPath);
            gr.DrawLine(Flecha, origen.X + origen.Radio, origen.Y + origen.Radio, destino.X + destino.Radio, destino.Y + destino.Radio);

            origen.Mostrar(gr);
            destino.Mostrar(gr);
            int xh = origen.X + (destino.X - origen.X) / 2;
            int yh = origen.Y + (destino.Y - origen.Y) / 2;
            gr.DrawString(peso.ToString(), new Font(new FontFamily("Arial"), 10, FontStyle.Bold), Brushes.Blue, xh, yh);
        }
    }
}