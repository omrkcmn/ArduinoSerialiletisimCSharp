using System;
using System.Windows.Forms;
using System.Data;
using System.IO.Ports;
using System.Drawing;

namespace Arduino
{
    public partial class Form1 : Form
    {
        SerialPort sPort;
        string portName;
        public Form1()
        {
            InitializeComponent();
            sPort = new SerialPort();
            sPort.BaudRate = 9600;
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            timer1.Start();
            try
            {
                sPort.PortName = txtPort.Text;
                if (!sPort.IsOpen)
                {
                    sPort.Open();
                    
                    lblSonuc.Visible = true;
                    lblSonuc.Text = "Bağlantı Kuruldu";
                    lblSonuc.ForeColor = Color.Green;
                }
            }
            catch (Exception)
            {
                lblSonuc.Visible = true;
                lblSonuc.Text = "Bağlantı Kurulamadı";
                lblSonuc.ForeColor = Color.IndianRed;
            }
        }

        private void btnKes_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sPort.Close();
            lblSonuc.Visible = true;
            lblSonuc.Text = "Bağlantı Sonlandırıldı";
            lblSonuc.ForeColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
              if (sPort.IsOpen)
              {
                  string deger = sPort.ReadLine();
                  progressBar1.Value = int.Parse(deger);
                  lblUzaklik.Text = deger;
              }               
            }
         
        }
    }
