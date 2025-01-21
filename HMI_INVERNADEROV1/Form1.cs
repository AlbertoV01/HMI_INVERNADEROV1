using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMI_INVERNADEROV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cmbPuertoComunicacion.Text;
                serialPort1.BaudRate = Convert.ToInt32(tb_BaudRate.Text);
                btn_Conectar.Enabled = false;
                btn_Desconectar.Enabled = true;
                btn_ActualizarPuertos.Enabled = true;
                serialPort1.Open();

            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                btn_Desconectar.Enabled = false;
                btn_ActualizarPuertos.Enabled = false;
                cmbPuertoComunicacion.DataSource = SerialPort.GetPortNames();
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btn_ActualizarPuertos_Click(object sender, EventArgs e)
        {
            
            cmbPuertoComunicacion.DataSource = SerialPort.GetPortNames();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int value = 0;
            string serialData = serialPort1.ReadLine();
            int.TryParse(serialData, out value);
           // int value = Convert.ToInt32(serialData);
            
            chart1.Invoke((MethodInvoker)(() => chart1.Series
            ["Temperatura"].Points.AddY(value)));
           
        }

        private void btn_Desconectar_Click(object sender, EventArgs e)
        {
            // SI TE QUIERES DESCONECTAR NO JALA Y NO SE POR K
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                btn_Conectar.Enabled = true;
                btn_Desconectar.Enabled = false;
                btn_ActualizarPuertos.Enabled = false;

            }
        }
    }
}
