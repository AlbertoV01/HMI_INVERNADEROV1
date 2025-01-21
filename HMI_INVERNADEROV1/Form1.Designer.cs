namespace HMI_INVERNADEROV1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_BaudRate = new System.Windows.Forms.TextBox();
            this.btn_ActualizarPuertos = new System.Windows.Forms.Button();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.cmbPuertoComunicacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_Desconectar = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.btn_Desconectar);
            this.panel1.Controls.Add(this.tb_BaudRate);
            this.panel1.Controls.Add(this.btn_ActualizarPuertos);
            this.panel1.Controls.Add(this.btn_Conectar);
            this.panel1.Controls.Add(this.cmbPuertoComunicacion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 629);
            this.panel1.TabIndex = 0;
            // 
            // tb_BaudRate
            // 
            this.tb_BaudRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tb_BaudRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_BaudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(176)))), ((int)(((byte)(232)))));
            this.tb_BaudRate.Location = new System.Drawing.Point(47, 172);
            this.tb_BaudRate.Name = "tb_BaudRate";
            this.tb_BaudRate.Size = new System.Drawing.Size(189, 22);
            this.tb_BaudRate.TabIndex = 6;
            // 
            // btn_ActualizarPuertos
            // 
            this.btn_ActualizarPuertos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_ActualizarPuertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActualizarPuertos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(176)))), ((int)(((byte)(232)))));
            this.btn_ActualizarPuertos.Location = new System.Drawing.Point(47, 333);
            this.btn_ActualizarPuertos.Name = "btn_ActualizarPuertos";
            this.btn_ActualizarPuertos.Size = new System.Drawing.Size(189, 30);
            this.btn_ActualizarPuertos.TabIndex = 5;
            this.btn_ActualizarPuertos.Text = "ACTUALIZAR PUERTOS";
            this.btn_ActualizarPuertos.UseVisualStyleBackColor = false;
            this.btn_ActualizarPuertos.Click += new System.EventHandler(this.btn_ActualizarPuertos_Click);
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_Conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Conectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(176)))), ((int)(((byte)(232)))));
            this.btn_Conectar.Location = new System.Drawing.Point(47, 225);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(189, 30);
            this.btn_Conectar.TabIndex = 4;
            this.btn_Conectar.Text = "CONECTAR";
            this.btn_Conectar.UseVisualStyleBackColor = false;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // cmbPuertoComunicacion
            // 
            this.cmbPuertoComunicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbPuertoComunicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPuertoComunicacion.FormattingEnabled = true;
            this.cmbPuertoComunicacion.Location = new System.Drawing.Point(47, 62);
            this.cmbPuertoComunicacion.Name = "cmbPuertoComunicacion";
            this.cmbPuertoComunicacion.Size = new System.Drawing.Size(189, 24);
            this.cmbPuertoComunicacion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.label2.Location = new System.Drawing.Point(44, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "VELOCIDAD DE TRANSMISION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PUERTO DE COMUNICACION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(330, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 279);
            this.panel2.TabIndex = 1;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btn_Desconectar
            // 
            this.btn_Desconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_Desconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Desconectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(176)))), ((int)(((byte)(232)))));
            this.btn_Desconectar.Location = new System.Drawing.Point(47, 277);
            this.btn_Desconectar.Name = "btn_Desconectar";
            this.btn_Desconectar.Size = new System.Drawing.Size(189, 30);
            this.btn_Desconectar.TabIndex = 8;
            this.btn_Desconectar.Text = "DESCONECTAR";
            this.btn_Desconectar.UseVisualStyleBackColor = false;
            this.btn_Desconectar.Click += new System.EventHandler(this.btn_Desconectar_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(78, 7);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Temperatura";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Humedad";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(741, 259);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(946, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "0 C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(946, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "0 C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1782, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ActualizarPuertos;
        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.ComboBox cmbPuertoComunicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_BaudRate;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_Desconectar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

