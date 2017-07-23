using System;
using System.Drawing;
namespace ComplejidadTF
{
    public class Nodo
    {
        private int valor;
        private string letra;
        private int x;
        private int y;
        int color;
        int estado;
        int radio;

        public Nodo(int valor, string letra, int x, int y, int estado)
        {
            this.valor = valor;
            this.letra = letra;
            this.x = x;
            this.y = y;
            this.color = 0;
            this.estado = estado;
            radio = 20;
        }

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Letra
        {
            get { return letra; }
            set { letra = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }        

        public int Y
        {
            get { return y; }
            set { y = value; }
        }       

        public int Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public void Mostrar(Graphics gr)
        {

            Color clr = ColorTranslator.FromWin32(50000);
            if (estado == Estados.SELECCIONADO)
            {
                Random r = new Random();
                clr = ColorTranslator.FromWin32(r.Next());
                gr.FillEllipse(new SolidBrush(clr), X, Y, radio*2, radio*2);
                gr.DrawString(letra, new Font(new FontFamily("Arial"), 10, FontStyle.Bold), Brushes.Red, x + radio - 7, y + radio - 7);
            }
            else if(estado == Estados.NO_SELECCIONADO)
            {
                gr.DrawEllipse(new Pen(clr, 3), X, Y, radio * 2, radio * 2);
                gr.DrawString(letra, new Font(new FontFamily("Arial"), 10, FontStyle.Bold), Brushes.Red, x + radio - 7, y + radio - 7);
            }
            else
            {
                gr.FillEllipse(new SolidBrush(clr), X, Y, radio * 2, radio * 2);
                gr.DrawString(letra, new Font(new FontFamily("Arial"), 10, FontStyle.Bold), Brushes.Red, x + radio - 7, y + radio - 7);
            }
        }
    }
}
