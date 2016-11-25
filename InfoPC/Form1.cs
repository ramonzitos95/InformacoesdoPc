using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using Macoratti.TesteEmail;
using System.Threading;

namespace InfoPC
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            excluirArquivo();    
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            PC pc = new PC();
            listInfo.Items.Add("Sistema Operacional: " + pc.versaoSO());
            listInfo.Items.Add(pc.ArquiteturaSO());
            listInfo.Items.Add(pc.ArquiteturaProcessador());
            listInfo.Items.Add("Nome do Computador: " + pc.GetNomeComputador());
            listInfo.Items.Add("Serial do HD: " + pc.getSerial("C"));
            listInfo.Items.Add("Endereço MAC ADDRESS: " + pc.GetMACAddress());
            listInfo.Items.Add("Qunatidade de memória: " + pc.quantidadeMemoria() + " MB");

            // Variaveis auxiliares
            ArrayList arlNetworkDeviceIP = new ArrayList();
            ArrayList arlNetworkDeviceDesc = new ArrayList();
            ArrayList arlNetworkDeviceMAC = new ArrayList();
            // Instancia a classe que trata o adaptador de rede
            NetWork objNetworkDevice = new NetWork();
            // Recupera os endereços IP
            arlNetworkDeviceIP = objNetworkDevice.GetIPAdress();
            // Recupera as descrições dos dispositivos de rede
            arlNetworkDeviceDesc = objNetworkDevice.GetDescription();
            // Recupera os MAC adresses dos dispositivos de rede
            arlNetworkDeviceMAC = objNetworkDevice.GetMACAddress();
            // Verifica se o arraylist está vazio
            listInfo.Items.Add("\t\t");
            if ((arlNetworkDeviceIP != null) || (arlNetworkDeviceDesc != null) || (arlNetworkDeviceMAC != null))
            {
                // Mostra as informações sobre a placa de rede
                for (int ind = 0; ind < arlNetworkDeviceIP.Count; ind++)
                {
                    listInfo.Items.Add("\t");
                    listInfo.Items.Add("Informações da Rede:");
                    listInfo.Items.Add("\t");
                    listInfo.Items.Add("Adaptador de Rede\t\t: " + arlNetworkDeviceDesc[ind].ToString());
                    listInfo.Items.Add("Endereço IP\t\t\t: " + arlNetworkDeviceIP[ind].ToString());
                    listInfo.Items.Add("MAC Address\t\t\t: " + arlNetworkDeviceMAC[ind].ToString());
                }
            }
     
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listInfo.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            excluirArquivo();
            StreamWriter wr = new StreamWriter(@"C:\Users\Ramon\Desktop\relatorio.txt", true);
            foreach (string itens in listInfo.Items)
            {
                wr.WriteLine(itens);
            }
                
            wr.Close();
            if (File.Exists(@"C:\Users\Ramon\Desktop\relatorio.txt"))
            {
                MessageBox.Show("O Arquivo foi gerado em seu desktop", "Geração do arquivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        public void excluirArquivo()
        {
            // Delete a file by using File class static method...
            if (File.Exists(@"C:\Users\Ramon\Desktop\relatorio.txt"))
            {
                // Use a try block to catch IOExceptions, to
                // handle the case of the file already being
                // opened by another process.
                try
                {
                    File.Delete(@"C:\Users\Ramon\Desktop\relatorio.txt");
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProcedimento));
            t.SetApartmentState(ApartmentState.STA);
            t.IsBackground = true;
            t.Start();
            this.Close();
        }

        public static void ThreadProcedimento()
        {
            Application.Run(new frmTesteEmail());
        }
    }
}
