using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Collections;

namespace InfoPC
{
    class PC
    {
        private ManagementObjectSearcher objBuscador;
        private ArrayList arlNetworkIP;
        private ArrayList arlNetworkDesc;
        private ArrayList arlNetworkMAC;
        private string informacoes { get; set; }
        private string versao { get; set; }
        private string  usuario { get; set; }
        private string runtime { get; set;  }
        private string diretorio { get; set; }

        public string versaoSO()
        {
            string retorno;
            retorno = "Versão do sistema operacional: " + Environment.OSVersion.ToString();
            return retorno;
        }

        public string ArquiteturaSO()
        {
            string retorno;
            if (Environment.Is64BitOperatingSystem == true)
            {
                retorno = "Sistema Operacional: 64Bits";
            }
            else
            {
                retorno = "Sistema Operacional: 32Bits";
            }
            
            return retorno;
        }

        public string ArquiteturaProcessador()
        {
            string retorno;
            if (Environment.Is64BitProcess == true)
            {
                retorno = "Processador: 64 Bits";
            }
            else
            {
                retorno = "Processador: 32 Bits";
            }

            return retorno;
        }

        public string getSerial(string strDriveLetter)
        {

            try
            {
                if (strDriveLetter == "" || strDriveLetter == null) strDriveLetter = "C";
                ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + strDriveLetter + ":\"");

                disk.Get();
                return disk["VolumeSerialNumber"].ToString();
            }
            catch
            {
                return "0";
            }
        }

        /// <summary>
        /// Returns MAC Address from first Network Card in Computer
        /// </summary>
        /// <returns>[string] MAC Address</returns>
        public string GetMACAddress()
        {
            try
            {
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                string MACAddress = String.Empty;
                foreach (ManagementObject mo in moc)
                {
                    if (MACAddress == String.Empty)  // only return MAC Address from first card
                    {
                        if ((bool)mo["IPEnabled"] == true) MACAddress = mo["MacAddress"].ToString();
                    }
                    mo.Dispose();
                }
                MACAddress = MACAddress.Replace(":", " ");
                return MACAddress;
            }
            catch
            {
                return "0";
            }
        }

        public string GetNomeComputador()
        {
            try
            {
                return Environment.MachineName.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int quantidadeMemoria()
        {
            int memoriaRam = 0;
            string Consulta = "SELECT MaxCapacity FROM Win32_PhysicalMemoryArray";
            ManagementObjectSearcher objetoPesquisado = new ManagementObjectSearcher(Consulta);

            //Feito isso iremos somar todos os valores encontrados para a memória RAM.
            foreach (ManagementObject WniPART in objetoPesquisado.Get())
            {
                UInt32 tamanhoKB = Convert.ToUInt32(WniPART.Properties["MaxCapacity"].Value);
                UInt32 tamanhoMB = tamanhoKB / 1024;
                memoriaRam += Convert.ToInt32(tamanhoMB);
            }

            return memoriaRam;

        }

        public string getUsuario()
        {
            string usuario = Environment.UserName;
            return usuario;
        }
    }
}
