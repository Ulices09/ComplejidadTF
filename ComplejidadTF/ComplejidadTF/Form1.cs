using System;
using System.Drawing;
using System.Windows.Forms;
namespace ComplejidadTF
{
    public partial class Form1 : Form
    {
        Graph graph;
        int v, cuentaRegresiva, estado;
        Graphics gr;
        BufferedGraphicsContext bgc;
        BufferedGraphics bg;
        public Form1()
        {
            InitializeComponent();

            comboBoxAlgoritmo.Items.Add("Bellman-Ford");
            comboBoxAlgoritmo.Items.Add("Kruskal");
            comboBoxAlgoritmo.SelectedIndex = 0;

            labelBM.Visible = false;
            labelCostoMinimo.Visible = false;
            labelBellmanFord.Visible = false;
            labelCM.Visible = false;
            labelPesoActual.Text = "0";
            buttonBellmanFord.Enabled = false;
            buttonKruskal.Enabled = false;

            cuentaRegresiva = 100; //Cada 10 es un segudno;
            v = 16; // Numero de nodos del grafo
            graph = new Graph(v);
            gr = this.CreateGraphics();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cuentaRegresiva--;
            labelTiempo.Text = (cuentaRegresiva / 10).ToString();
            if (cuentaRegresiva == 0)
            {
                //timer1.Stop();
                DialogResult dialogResult = MessageBox.Show("No lo conseguiste ¿Intentarlo Nuevamente?", "Juego Perdido", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //this.Close();
                    cuentaRegresiva = 100;
                    if (estado == Estados.BELLMAN_FORD) GenerarGrafo("Bellman-Ford");
                    else GenerarGrafo("Kruskal");
                    //timer1.Start();
                }
                else if (dialogResult == DialogResult.No)
                {
                    estado = Estados.FINALIZADO;
                    this.Close();
                }
            }

            if (estado != Estados.FINALIZADO)
            {
                bgc = BufferedGraphicsManager.Current;
                bg = bgc.Allocate(gr, this.ClientRectangle);

                if (estado == Estados.BELLMAN_FORD) graph.MostrarBellman(bg.Graphics);
                else graph.Mostrar(bg.Graphics);
                bg.Render(gr);
            }
        }

        private void buttonKruskal_Click(object sender, EventArgs e)
        {
            labelCostoMinimo.Text = graph.KruskalMST(1).ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            double pesoActual = graph.SeleccionarNodo(Cursor.Position.X, Cursor.Position.Y);
            labelPesoActual.Text = pesoActual.ToString();

            if (graph.Estado == Estados.COMPLETADO && estado == Estados.BELLMAN_FORD)
            {
                if (pesoActual == graph.ObtenerPesoOriginADestino())
                {
                    timer1.Stop();
                    DialogResult dialogResult = MessageBox.Show("Lo conseguiste ¿Jugar Nuevamente?", "Juego Ganado", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cuentaRegresiva = 800;
                        GenerarGrafo("Bellman-Ford");
                        timer1.Start();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        estado = Estados.FINALIZADO;
                        this.Close();
                    }
                }
                else
                {
                    timer1.Stop();
                    DialogResult dialogResult = MessageBox.Show("No lo conseguiste ¿Intentarlo Nuevamente?", "Juego Perdido", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cuentaRegresiva = 800;
                        GenerarGrafo("Kruskal");
                        timer1.Start();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        estado = Estados.FINALIZADO;
                        this.Close();
                    }
                }
            }
            else if (graph.Estado == Estados.COMPLETADO && estado == Estados.KRUSKAL)
            {
                if (pesoActual <= Convert.ToInt32(labelCostoMinimo))
                {
                    MessageBox.Show("Bien, el recorrido es menor al costo mínimo de todos los nodos");
                }
                else
                {
                    MessageBox.Show("Mal, el recorrido es mayor al costo mínimo de todos los nodos");
                }
            }
        }

        private void GenerarGrafo(string algoritmo)
        {
            if (algoritmo.Equals("Bellman-Ford"))
            {
                estado = Estados.BELLMAN_FORD;
                labelBM.Visible = true;
                labelCM.Visible = false;
                labelCostoMinimo.Visible = false;
                labelBellmanFord.Visible = true;
                buttonBellmanFord.Enabled = true;
                buttonKruskal.Enabled = false;

                if (graph != null) graph = null;
                graph = new Graph(v);

                Nodo nodo1 = new Nodo(0, "A", 200, 400, Estados.SELECCIONADO);
                Nodo nodo2 = new Nodo(1, "B", 300, 300, Estados.NO_SELECCIONADO);
                Nodo nodo3 = new Nodo(2, "C", 280, 380, Estados.NO_SELECCIONADO);
                Nodo nodo4 = new Nodo(3, "D", 300, 500, Estados.NO_SELECCIONADO);

                Nodo nodo5 = new Nodo(4, "E", 300, 600, Estados.NO_SELECCIONADO);
                Nodo nodo6 = new Nodo(5, "F", 410, 220, Estados.NO_SELECCIONADO);
                Nodo nodo7 = new Nodo(6, "G", 500, 300, Estados.NO_SELECCIONADO);
                Nodo nodo8 = new Nodo(7, "H", 150, 250, Estados.NO_SELECCIONADO);

                Nodo nodo9 = new Nodo(8, "I", 480, 430, Estados.NO_SELECCIONADO);
                Nodo nodo10 = new Nodo(9, "J", 600, 500, Estados.NO_SELECCIONADO);
                Nodo nodo11 = new Nodo(10, "K", 470, 570, Estados.NO_SELECCIONADO);
                Nodo nodo12 = new Nodo(11, "L", 670, 600, Estados.NO_SELECCIONADO);

                Nodo nodo13 = new Nodo(12, "M", 700, 380, Estados.NO_SELECCIONADO);
                Nodo nodo14 = new Nodo(13, "N", 670, 220, Estados.NO_SELECCIONADO);
                Nodo nodo15 = new Nodo(14, "O", 800, 200, Estados.NO_SELECCIONADO);
                Nodo nodo16 = new Nodo(15, "P", 830, 480, Estados.DESTINO);


                graph.addArista(nodo1, nodo2); graph.addArista(nodo3, nodo7);
                graph.addArista(nodo1, nodo3); graph.addArista(nodo3, nodo9);
                graph.addArista(nodo1, nodo4); graph.addArista(nodo4, nodo5);
                graph.addArista(nodo1, nodo8); graph.addArista(nodo5, nodo11);
                graph.addArista(nodo2, nodo6); graph.addArista(nodo5, nodo12);
                graph.addArista(nodo2, nodo7); graph.addArista(nodo6, nodo7);
                graph.addArista(nodo3, nodo4); graph.addArista(nodo6, nodo14);
                graph.addArista(nodo7, nodo9); graph.addArista(nodo7, nodo10);
                graph.addArista(nodo7, nodo13); graph.addArista(nodo7, nodo14);
                graph.addArista(nodo8, nodo2); graph.addArista(nodo9, nodo11);
                graph.addArista(nodo10, nodo12); graph.addArista(nodo10, nodo13);
                graph.addArista(nodo10, nodo16); graph.addArista(nodo11, nodo10);
                graph.addArista(nodo11, nodo12); graph.addArista(nodo12, nodo13);
                graph.addArista(nodo12, nodo16); graph.addArista(nodo13, nodo15);
                graph.addArista(nodo13, nodo16); graph.addArista(nodo14, nodo13);
                graph.addArista(nodo14, nodo15); graph.addArista(nodo15, nodo16);
            }
            else
            {
                estado = Estados.KRUSKAL;
                labelBM.Visible = false;
                labelCM.Visible = true;
                labelCostoMinimo.Visible = true;
                labelBellmanFord.Visible = false;
                buttonBellmanFord.Enabled = false;
                buttonKruskal.Enabled = true;

                if (graph != null) graph = null;
                graph = new Graph(v);

                Random rn = new Random();
                int rX = rn.Next(1, 750);
                int rY = rn.Next(1, 750);

                Nodo nodo1 = new Nodo(0, "A", rX, rY, Estados.SELECCIONADO);

                rX = rn.Next(1, 750);
                rY = rn.Next(1, 750);
                Nodo nodo2 = new Nodo(1, "B", rX, rY, Estados.NO_SELECCIONADO);
                rX = rn.Next(1, 750);
                rY = rn.Next(1, 750);
                Nodo nodo3 = new Nodo(2, "C", rX, rY, Estados.NO_SELECCIONADO);
                rX = rn.Next(1, 750);
                rY = rn.Next(1, 750);
                Nodo nodo4 = new Nodo(3, "D", rX, rY, Estados.NO_SELECCIONADO);
                rX = rn.Next(1, 750);
                rY = rn.Next(1, 750);

                Nodo nodo5 = new Nodo(4, "E", rX, rY, Estados.NO_SELECCIONADO);
                rX = rn.Next(1, 750);
                rY = rn.Next(1, 750);
                Nodo nodo6 = new Nodo(5, "F", rX, rY, Estados.NO_SELECCIONADO);
                rX = rn.Next(1, 750);
                rY = rn.Next(1, 750);
                Nodo nodo7 = new Nodo(6, "G", rX, rY, Estados.NO_SELECCIONADO);
                rX = rn.Next(1, 750);
                rY = rn.Next(1, 750);
                Nodo nodo8 = new Nodo(7, "H", rX, rY, Estados.NO_SELECCIONADO);
                rX = rn.Next(1, 750);
                rY = rn.Next(1, 750);

                Nodo nodo9 = new Nodo(8, "I", rX, rY, Estados.NO_SELECCIONADO);
                rX = rn.Next(1, 750);
                rY = rn.Next(1, 750);
                Nodo nodo10 = new Nodo(9, "J", rX, rY, Estados.NO_SELECCIONADO);
                rX = rn.Next(1, 750);
                rY = rn.Next(1, 750);
                Nodo nodo11 = new Nodo(10, "K", rX, rY, Estados.NO_SELECCIONADO);
                rX = rn.Next(1, 750);
                rY = rn.Next(1, 750);
                Nodo nodo12 = new Nodo(11, "L", rX, rY, Estados.NO_SELECCIONADO);
                rX = rn.Next(1, 750);
                rY = rn.Next(1, 750);

                Nodo nodo13 = new Nodo(12, "M", rX, rY, Estados.NO_SELECCIONADO);
                rX = rn.Next(1, 750);
                rY = rn.Next(1, 750);
                Nodo nodo14 = new Nodo(13, "N", rX, rY, Estados.NO_SELECCIONADO);
                rX = rn.Next(1, 750);
                rY = rn.Next(1, 750);
                Nodo nodo15 = new Nodo(14, "O", rX, rY, Estados.NO_SELECCIONADO);
                rX = rn.Next(1, 750);
                rY = rn.Next(1, 750);
                Nodo nodo16 = new Nodo(15, "P", rX, rY, Estados.DESTINO);
                rX = rn.Next(1, 750);
                rY = rn.Next(1, 750);

                graph.addArista(nodo1, nodo2); graph.addArista(nodo3, nodo7);
                graph.addArista(nodo1, nodo3); graph.addArista(nodo3, nodo9);
                graph.addArista(nodo1, nodo4); graph.addArista(nodo4, nodo5);
                graph.addArista(nodo1, nodo8); graph.addArista(nodo5, nodo11);
                graph.addArista(nodo2, nodo6); graph.addArista(nodo5, nodo12);
                graph.addArista(nodo2, nodo7); graph.addArista(nodo6, nodo7);
                graph.addArista(nodo3, nodo4); graph.addArista(nodo6, nodo14);
                graph.addArista(nodo7, nodo9); graph.addArista(nodo7, nodo10);
                graph.addArista(nodo7, nodo13); graph.addArista(nodo7, nodo14);
                graph.addArista(nodo8, nodo2); graph.addArista(nodo9, nodo11);
                graph.addArista(nodo10, nodo12); graph.addArista(nodo10, nodo13);
                graph.addArista(nodo10, nodo16); graph.addArista(nodo11, nodo10);
                graph.addArista(nodo11, nodo12); graph.addArista(nodo12, nodo13);
                graph.addArista(nodo12, nodo16); graph.addArista(nodo13, nodo15);
                graph.addArista(nodo13, nodo16); graph.addArista(nodo14, nodo13);
                graph.addArista(nodo14, nodo15); graph.addArista(nodo15, nodo16);

                labelCostoMinimo.Text = graph.KruskalMST(0).ToString();

            }
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; timer1.Start();

            if (comboBoxAlgoritmo.SelectedItem.Equals("Bellman-Ford"))
            {
                GenerarGrafo("Bellman-Ford");
                labelBellmanFord.Visible = false;
            }
            else
            {
                GenerarGrafo("Kruskal");
            }
        }

        void Reset()
        {
            cuentaRegresiva = 100;
            if (estado == Estados.BELLMAN_FORD) GenerarGrafo("Bellman-Ford");
            else GenerarGrafo("Kruskal");
            labelBellmanFord.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void comboBoxAlgoritmo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBellmanFord_Click(object sender, EventArgs e)
        {
            if (labelBellmanFord.Visible == true) labelBellmanFord.Visible = false;
            else labelBellmanFord.Visible = true;
            labelBellmanFord.Text = graph.BellmanFord();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
