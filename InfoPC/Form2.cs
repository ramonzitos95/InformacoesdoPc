using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoPC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            limpaCampos();
            desativarCampos();
            preencheInformacoesSO();            
            preencheListaRede();
        }

        public void preencheInformacoesSO()
        {
            PC pc = new PC();
            txtNomePC.Text = pc.GetNomeComputador();
            txtArquiteturaProcessador.Text = pc.ArquiteturaProcessador();
            txtArquiteturaSO.Text = pc.ArquiteturaSO();
            txtMacAddres.Text = pc.GetMACAddress();
            txtUsuario.Text = pc.getUsuario();
            txtSerial.Text = pc.getSerial("C");
            txtQuantidadeMemoria.Text = Convert.ToString(pc.quantidadeMemoria());
            txtVersaoSO.Text = pc.versaoSO();

        }

        public void preencheListaRede()
        {
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
            listViewRede.Items.Add("\t\t");
            if ((arlNetworkDeviceIP != null) || (arlNetworkDeviceDesc != null) || (arlNetworkDeviceMAC != null))
            {
                // Mostra as informações sobre a placa de rede
                for (int ind = 0; ind < arlNetworkDeviceIP.Count; ind++)
                {
                    listViewRede.Items.Add("\n");
                    listViewRede.Items.Add("Informações da Rede:");
                    listViewRede.Items.Add("\n");
                    listViewRede.Items.Add("Adaptador de Rede\t\t: " + arlNetworkDeviceDesc[ind].ToString());
                    listViewRede.Items.Add("Endereço IP\t " + arlNetworkDeviceIP[ind].ToString());
                    listViewRede.Items.Add("MAC Address\t: " + arlNetworkDeviceMAC[ind].ToString());
                }
            }
        }

        public void limpaCampos()
        {
            txtNomePC.Text = "";
            txtArquiteturaProcessador.Text = "";
            txtArquiteturaSO.Text = "";
            txtMacAddres.Text = "";
            txtUsuario.Text = "";
            txtSerial.Text = "";
            txtQuantidadeMemoria.Text = "";
            txtVersaoSO.Text = "";
            listViewRede.Clear();
        }

        public void desativarCampos()
        {
            txtNomePC.Enabled = false;
            txtArquiteturaProcessador.Enabled = false;
            txtArquiteturaSO.Enabled = false;
            txtMacAddres.Enabled = false;
            txtUsuario.Enabled = false;
            txtSerial.Enabled = false;
            txtQuantidadeMemoria.Enabled = false;
            txtVersaoSO.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Atualizando informações do campo
            preencheInformacoesSO();
            preencheListaRede();
        }
    }
}
