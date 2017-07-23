namespace ComplejidadTF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonKruskal = new System.Windows.Forms.Button();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.labelPesoActual = new System.Windows.Forms.Label();
            this.comboBoxAlgoritmo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCM = new System.Windows.Forms.Label();
            this.labelCostoMinimo = new System.Windows.Forms.Label();
            this.labelBellmanFord = new System.Windows.Forms.Label();
            this.labelBM = new System.Windows.Forms.Label();
            this.buttonBellmanFord = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonKruskal
            // 
            this.buttonKruskal.Location = new System.Drawing.Point(595, 27);
            this.buttonKruskal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKruskal.Name = "buttonKruskal";
            this.buttonKruskal.Size = new System.Drawing.Size(100, 28);
            this.buttonKruskal.TabIndex = 2;
            this.buttonKruskal.Text = "Kruskal";
            this.buttonKruskal.UseVisualStyleBackColor = true;
            this.buttonKruskal.Click += new System.EventHandler(this.buttonKruskal_Click);
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Location = new System.Drawing.Point(1271, 14);
            this.labelTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(36, 17);
            this.labelTiempo.TabIndex = 2;
            this.labelTiempo.Text = "0:00";
            // 
            // labelPesoActual
            // 
            this.labelPesoActual.AutoSize = true;
            this.labelPesoActual.Location = new System.Drawing.Point(1271, 50);
            this.labelPesoActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPesoActual.Name = "labelPesoActual";
            this.labelPesoActual.Size = new System.Drawing.Size(16, 17);
            this.labelPesoActual.TabIndex = 3;
            this.labelPesoActual.Text = "0";
            // 
            // comboBoxAlgoritmo
            // 
            this.comboBoxAlgoritmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgoritmo.FormattingEnabled = true;
            this.comboBoxAlgoritmo.Location = new System.Drawing.Point(99, 23);
            this.comboBoxAlgoritmo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxAlgoritmo.Name = "comboBoxAlgoritmo";
            this.comboBoxAlgoritmo.Size = new System.Drawing.Size(160, 24);
            this.comboBoxAlgoritmo.TabIndex = 0;
            this.comboBoxAlgoritmo.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlgoritmo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Algoritmo: ";
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(268, 23);
            this.buttonCrear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(128, 28);
            this.buttonCrear.TabIndex = 1;
            this.buttonCrear.Text = "Generar y Jugar";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1120, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tiempo Restante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1120, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Costo Actual:";
            // 
            // labelCM
            // 
            this.labelCM.AutoSize = true;
            this.labelCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCM.Location = new System.Drawing.Point(1120, 81);
            this.labelCM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCM.Name = "labelCM";
            this.labelCM.Size = new System.Drawing.Size(109, 17);
            this.labelCM.TabIndex = 9;
            this.labelCM.Text = "Costo Mínimo:";
            // 
            // labelCostoMinimo
            // 
            this.labelCostoMinimo.AutoSize = true;
            this.labelCostoMinimo.Location = new System.Drawing.Point(1271, 81);
            this.labelCostoMinimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCostoMinimo.Name = "labelCostoMinimo";
            this.labelCostoMinimo.Size = new System.Drawing.Size(16, 17);
            this.labelCostoMinimo.TabIndex = 10;
            this.labelCostoMinimo.Text = "0";
            // 
            // labelBellmanFord
            // 
            this.labelBellmanFord.AutoSize = true;
            this.labelBellmanFord.Location = new System.Drawing.Point(1271, 117);
            this.labelBellmanFord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBellmanFord.Name = "labelBellmanFord";
            this.labelBellmanFord.Size = new System.Drawing.Size(13, 17);
            this.labelBellmanFord.TabIndex = 11;
            this.labelBellmanFord.Text = "-";
            // 
            // labelBM
            // 
            this.labelBM.AutoSize = true;
            this.labelBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBM.Location = new System.Drawing.Point(1120, 117);
            this.labelBM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBM.Name = "labelBM";
            this.labelBM.Size = new System.Drawing.Size(109, 17);
            this.labelBM.TabIndex = 12;
            this.labelBM.Text = "Bellman-Ford:";
            // 
            // buttonBellmanFord
            // 
            this.buttonBellmanFord.Location = new System.Drawing.Point(476, 27);
            this.buttonBellmanFord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBellmanFord.Name = "buttonBellmanFord";
            this.buttonBellmanFord.Size = new System.Drawing.Size(111, 28);
            this.buttonBellmanFord.TabIndex = 3;
            this.buttonBellmanFord.Text = "Bellman Ford";
            this.buttonBellmanFord.UseVisualStyleBackColor = true;
            this.buttonBellmanFord.Click += new System.EventHandler(this.buttonBellmanFord_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(737, 30);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 690);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.buttonBellmanFord);
            this.Controls.Add(this.labelBM);
            this.Controls.Add(this.labelBellmanFord);
            this.Controls.Add(this.labelCostoMinimo);
            this.Controls.Add(this.labelCM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAlgoritmo);
            this.Controls.Add(this.labelPesoActual);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.buttonKruskal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complejidad TF";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonKruskal;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label labelPesoActual;
        private System.Windows.Forms.ComboBox comboBoxAlgoritmo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCM;
        private System.Windows.Forms.Label labelCostoMinimo;
        private System.Windows.Forms.Label labelBellmanFord;
        private System.Windows.Forms.Label labelBM;
        private System.Windows.Forms.Button buttonBellmanFord;
        private System.Windows.Forms.Button btnReset;
    }
}

