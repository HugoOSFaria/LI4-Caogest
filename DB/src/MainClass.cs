using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoGest.src{
    class MainClass{
        public static void Main(){
            //-----------------------------------------------------------------------------------------------Iniciar Sessão---------------------------------------------------------------------
            void iniciarSessaoU(string email, string password){
                if (canilDB.containsKey(email) && canilDB.valPalavra(password)){
                    //Informar para reabrir a pagina
                }
                else
                {
                    //Informar o site que não foi reconhecido o email ou a palavra-passe
                }
            }
            
            void iniciarSessaoCanil(string email, string password){
                if (canilDB.containsKey(email) && canilDB.valPalavra(password)){
                    //Informar para reabrir a pagina
                }
                else{
                    //Informar o site que não foi reconhecido o email ou a palavra-passe
                }
            }
            
            void terminarSessao(){
                //... acho que não é preciso fazer nada deste lado...
            }
            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            

            //----------------------------------------------------------------------------------------------Funções Utilizador-----------------------------------------------------------------------------
            void adicionarUtilizador(string email, string password, string nome, int cc, DateTime dataNasc, int idade, string morada){
                if (canilDB.containsKey(email)){
                    //Informar que mail ja existe
                }
                else{
                    canilDB.adicionarBD(email, password, nome, cc, dataNasc, idade, morada);
                }
            }
            
            void removerUtilizador(string email){
                canilDB.removerUtilizador(email);
            }
            
            void alterarPalU(string email, string nPass){
                canilDB.alterarPal(email, nPass);
            }
            
            void alterarEmailU(string email, string nPass){
                canilDB.editarEmail(email, novoEmail);
            }
            
            void registaHorario(string emailC, string emailV, DateTime horarioI, DateTime horarioF){
                canilDB.adicionarCanil(emailC, emailV, horarioI, horarioF);
            }
            
            void desmarcaHorario(string emailC, string emailV, DateTime horarioI, DateTime horarioF){
                canilDB.desmarcaHorario(emailC, emailV, horarioI, horarioF);
            }
            
            void favoritarCao(string email, int caoID){
                canilDB.favoritarCao(email, caoID);
            }

            void desfavoritarCao(string email, int caoID){
                canilDB.favoritarCao(email, caoID);
            }

            void adotarCao(string email, int caoID){
                canilDB.adotarCao(email, caoID);
                canilDB.adotarCao(caoID);
            }

            void pesquisaCao(string raca, int idade, string local){
                canilDB.pesquisaCao(local);
            }
            
            void pesquisaCao(string raca, int idade, char sexo, string cor, char porte, string local){
                canilDB.pesquisaCao(raca, idade, sexo, cor, porte, local);
            }
            
            void pesquisaCaoCanil(string raca, int idade, char sexo, string cor, char porte, string emailC){
                canilDB.pesquisaCaoCanil(raca, idade, sexo, cor, porte, emailC);
            }

            void pesquisaCanil(string local){
                canilDB.canisProximos(local);
            }

            void verParcerias(string emailC){
                List<List<String>> list = new List<List<String>>();
                list = canilDB.SelectParcerias(emailC);
                //Passar lista para o encapsulamento e mandar para site
            }
            
            //----------------------------------------------------------------------------------------------Funções Canis-----------------------------------------------------------------------------
            void adicionarCanil(string email, string nome, string password, int capO, int capT, string distrito, string rua, string local, string contacto, string nib){
                if (canilDB.containsKey()){
                    //mensagem de erro
                }
                else canilDB.insereCanil(email, nib, nome, capO, capT, password, distrito, rua, local, contacto);
            }
            
            void removerCanil(string email){
                canilDB.deleteCanil(email);
            }

            void alterarPalC(string email, string nPass){
                canilDB.updatePass(email, nPass);
            }
            
            void alterarEmailC(string email, string nEmail){
                canilDB.updateContacto(email, nEmail);
            }
            
            void adicionarParceria(string emailC, string nome, string info){
                canilDB.adicionarParceria(emailC, nome, info);
            }
            
            void removerParceria(string emailC, string nome){
                canilDB.removerParceria(emailC, nome);
            }

            void adicionaHorario(string emailC, DateTime horarioI, DateTime horarioF){
                canilDB.adicionarHorario(emailC, horarioI, horarioF);
            }
            
            void removeHorario(string emailC, DateTime horarioI, DateTime horarioF){
                canilDB.removeHorario(emailC, horarioI, horarioF);
            }
            
            void adicionarCao(string emailC, char genero, string nome, string cor, string raca, int idade, string descricao){
                int caoId = canilDB.adicionarCao(genero, nome, cor, raca, idade, descricao);
                canilDB.adicionarCao(emailC, caoID);
            }
            
            void removerCao(string emailC, int caoID){
                canilDB.removerCao(emailC, caoID);
                canilDB.removerCao(caoID);
            }

            void updateCapT(string email, int capT){
                canilDB.updateCapacidadeT(email, capT);
            }

            void updateCapO(string email, int capO){
                canilDB.updateCapacidadeO(email, capO);
            }

            //canilDB.insereCanil(""random@gmail.com", "192888494", "Novo canilDB", 10, 25, "minhapass", "porto", "Rua do teste","Lousada","912839913");

            // canilDB.updateCapacidadeO(""random@gmail.com", 100);

            // canilDB.updatePass("random@gmail.com", "PAAAAASS");

            // canilDB.updateContacto(""random@gmail.com", "935373306");

            // canilDB.deleteCanil(""random@gmail.com");

            /* List<string> list = canilDB.Select("random@gmail.com");
             Console.Write(list[0]);
             Console.Write(list[1]);
             Console.Write(list[2]);
             Console.Write(list[3]);
             Console.Write(list[4]);
             Console.Write(list[5]);
             Console.Write(list[6]);
             Console.Write(list[7]);
             Console.Write(list[8]);
             */


            /* TENTATIVA SO COM LISTA
            List<String> list = canilDB.SelectParcerias("caoSeguro@gmail.com");

            Console.Write(list[0]+'\n');
            Console.Write(list[1] + '\n');
            Console.Write(list[2] + '\n');
            Console.Write(list[3] + '\n');
            Console.Write(list[4] + '\n');
            Console.Write(list[5] + '\n');
            Console.Write(list[6] + '\n');
            Console.Write(list[7] + '\n');
            */

            /*TENTATIVA COM LISTA DE LISTAS
            List<List<String>> list = canilDB.SelectParcerias("caoSeguro@gmail.com");
            try
            {
                Console.Write((list[0])[0]+'\n');
                Console.Write((list[0])[1]+'\n');
                Console.Write((list[0])[2]+'\n');
                Console.Write((list[0])[3]+'\n');
                Console.Write((list[1])[0]+'\n');
                Console.Write((list[1])[1]+'\n');
                Console.Write((list[1])[2]+'\n');
                Console.Write((list[1])[3]+'\n');
            }
            catch (System.ArgumentOutOfRangeException) { }*/

            List<List<String>> list = canilDB.SelectCaes("caoSeguro@gmail.com");
            try {
            Console.Write((list[0])[0] + '\n');
            Console.Write((list[0])[1] + '\n');
            Console.Write((list[0])[2] + '\n');
            Console.Write((list[0])[3] + '\n');
            Console.Write((list[0])[4] + '\n');
            Console.Write((list[0])[5] + '\n');
            Console.Write((list[0])[6] + '\n');
            Console.Write((list[0])[7] + '\n');
            Console.Write((list[0])[8] + '\n');
            Console.Write((list[0])[9] + '\n');
                Console.Write((list[1])[0] + '\n');
                Console.Write((list[1])[1] + '\n');
                Console.Write((list[1])[2] + '\n');
                Console.Write((list[1])[3] + '\n');
                Console.Write((list[1])[4] + '\n');
                Console.Write((list[1])[5] + '\n');
                Console.Write((list[1])[6] + '\n');
                Console.Write((list[1])[7] + '\n');
                Console.Write((list[1])[8] + '\n');
                Console.Write((list[1])[9] + '\n');

            }
            catch (System.ArgumentOutOfRangeException) { }








        }
    }
}
