using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace InfoPC
{
    class NetWork
    {
        #region DECLARAÇÕES
        private ManagementObjectSearcher objBuscador;
        private ArrayList arlNetworkIP;
        private ArrayList arlNetworkDesc;
        private ArrayList arlNetworkMAC;
        #endregion

        #region 
        /// -------------------------------------------------------------------
        /// <summary> Contrutor padrão da classe </summary>
        /// <remarks>
        ///         Autor: Rafael Tudela
        /// </remarks>
        /// -------------------------------------------------------------------
        public NetWork()
        {
            // Retorna as informações sobre a placa de rede
            objBuscador = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration");
            // ArrayList que irá guardar as informações de IP dos adaptadores de rede
            arlNetworkIP = new ArrayList();
            // ArrayList que irá guardar as informações de Descrição dos adaptadores de rede
            arlNetworkDesc = new ArrayList();
            // ArrayList que irá guardar as informações do MAC Address dos adaptadores de rede
            arlNetworkMAC = new ArrayList();
        }
        #endregion

        #region FUNÇÕES PÚBLICAS
        /// -------------------------------------------------------------------
        /// <summary> Função que retorna o IP da placa de rede </summary>
        /// <returns> Lista de endereços IP da placa de rede </returns>
        /// <remarks>
        ///         Autor: Rafael Tudela
        /// </remarks>
        /// -------------------------------------------------------------------
        public ArrayList GetIPAdress()
        {
            try
            {
                // Variáveis auxiliares
                object objIPAdress;
                // Percorre a lista de adaptadores de rede
                foreach (ManagementObject wmi_Network in objBuscador.Get())
                {
                    // Retorna o endereço IP da placa de rede
                    try
                    {
                        // Recupera o endereço IP da placa corrente
                        object[] objIP = (object[])wmi_Network["IPAddress"];
                        // Retorna o endereço IP da placa de rede
                        objIPAdress = objIP[0].ToString();
                    }
                    catch
                    {
                        // Retorna o endereço IP da placa de rede
                        objIPAdress = "N/A";
                    }
                    // Grava as informações obtidas na lista
                    arlNetworkIP.Add(objIPAdress);
                }

                // Retorna a lista previamente preenchida
                return arlNetworkIP;
            }
            catch
            {
                // Retorna vazio
                return null;
            }
        }

        /// -------------------------------------------------------------------
        /// <summary> Função que retorna a descrição dos dispositivos de rede </summary>
        /// <returns> Lista de descrições dos dispositivos de rede </returns>
        /// <remarks>
        ///         Autor: Rafael Tudela
        /// </remarks>
        /// -------------------------------------------------------------------
        public ArrayList GetDescription()
        {
            try
            {
                // Variáveis auxiliares
                object objDescription;
                // Percorre a lista de adaptadores de rede
                foreach (ManagementObject wmi_Network in objBuscador.Get())
                {
                    try
                    {
                        // Retorna a descrição do dispositivo de rede
                        objDescription = wmi_Network["Description"];
                    }
                    catch
                    {
                        // Retorna a descrição do dispositivo de rede
                        objDescription = "N/A";
                    }
                    // Grava as informações obtidas na lista
                    arlNetworkDesc.Add(objDescription);
                }

                // Retorna a lista previamente preenchida
                return arlNetworkDesc;
            }
            catch
            {
                // Retorna vazio
                return null;
            }
        }

        /// -------------------------------------------------------------------
        /// <summary> Função que retorna o MAC address dos dispositivos de rede </summary>
        /// <returns> Lista de MAC address dos dispositivos de rede </returns>
        /// <remarks>
        ///         Autor: Rafael Tudela
        /// </remarks>
        /// -------------------------------------------------------------------
        public ArrayList GetMACAddress()
        {
            try
            {
                // Variáveis auxiliares
                object objMACAdd;
                // Percorre a lista de adaptadores de rede
                foreach (ManagementObject wmi_Network in objBuscador.Get())
                {
                    try
                    {
                        // Recupera o endereço MAC do dispositivo de rede
                        object objMAC = wmi_Network["MACAddress"];
                        // Retorna o endereço MAC do dispositivo de rede
                        objMACAdd = objMAC.ToString();
                    }
                    catch
                    {
                        // Retorna o endereço MAC do dispositivo de rede
                        objMACAdd = "N/A";
                    }
                    // Grava as informações obtidas na lista
                    arlNetworkMAC.Add(objMACAdd);
                }

                // Retorna a lista previamente preenchida
                return arlNetworkMAC;
            }
            catch
            {
                // Retorna vazio
                return null;
            }
        }
        #endregion
    }
}
    

