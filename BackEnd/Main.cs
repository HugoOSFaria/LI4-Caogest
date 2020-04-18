using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace LI4BackEnd
{
    class Main
    {
        static void main(string[] args)
        {

            // Colocamos o IP do Servidor como sendo o nosso IP e colocamos o porto como 9999
            TcpListener server = new TcpListener(IPAddress.Any, 9999);

            server.Start();

            // Espera por uma conexão
            while (true)
            {

                // Se existir conexão o Servidor conecta
                TcpClient cliente = server.AcceptTcpClient();

                // Uma NetworkStream é usada para enviar e receber mensagens
                NetworkStream networkStream = cliente.GetStream();

                // Criação do objecto Mensagem a ser posteriormente convertido em string jSon e enviado
                Mensagem mensagemServidor = new Mensagem();

                // Qualquer mensagem a ser enviada deve ser serializada (convertida em bytes)
                byte[] bytesServidor = new byte[512];

                // conversão da mensagem numa string jSon
                string jSonServer = mensagemServidor.saveMensagem(mensagemServidor.getTipo(), mensagemServidor.getCanis(), mensagemServidor.getUtilizadores(), mensagemServidor.getCaes());

                // Conversão de string para array de bytes
                bytesServidor = Encoding.Default.GetBytes(jSonServer);

                // envio da Mensagem
                networkStream.Write(bytesServidor, 0, bytesServidor.Length);

                // Enquanto o cliente se mantiver conectado, procura-se por mensagens a serem recebidas.
                while (cliente.Connected)
                {

                    // A mensagem deve chegar como um array de bytes
                    byte[] bytesCliente = new byte[1024];

                    // A mesma NetworkStream lê a mensagem enviada pelo cliente
                    networkStream.Read(bytesCliente, 0, bytesCliente.Length);

                    // Mensagem recebida é convertida numa string jSon a partir do seu estado original de array de bytes
                    string jSonCliente = BitConverter.ToString(bytesCliente);

                    // Criada uma Mensagem a ser carregada
                    Mensagem mensagemCliente = new Mensagem();

                    // Carregar um objecto Mensagem a partir da string jSon recebida
                    mensagemCliente.loadMensagem(jSonCliente);

                }
            }
        }

    }
}
