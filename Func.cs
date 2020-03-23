using System;

namespace ConsoleApp1{
    class Program{
        void iniciarSessao(string email, string password){
            if (utilizador.containsKey(email) && utilizador.valPalavra(password)){
                //Informar para reabrir a pagina
            }
            else{
                //Informar o site que não foi reconhecido o email ou a palavra-passe
            }
        }
        void iniciarSessao(string email, string password){
            if (utilizador.containsKey(email) && utilizador.valPalavra(password)){
                //Informar para reabrir a pagina
            }
            else{
                //Informar o site que não foi reconhecido o email ou a palavra-passe
            }
        }
        void terminarSessao(){
            //... acho que não é preciso fazer nada deste lado...
        }
        void adicionarUtilizador(string email, string password, string nome, int cc, DateTime dataNasc, int idade, string morada){
            if (utilizadores.containsKey(email)){
                //Informar que mail ja existe
            }
            else{
                utilizadores.adicionarBD(email, password, nome, cc, dataNasc, idade, morada);
            }
        }
        void alterarPalU(string email, string nPass){
            utilizadores.alterarPal(email, nPass);
        }
        void alterarEmailU(string email, string nPass){
            utilizadores.editarEmail(email,novoEmail);
        }
        void alterarPalC(string email, string nPass){
            canil.alterarPal(email, nPass);
        }
        void alterarEmailC(string email, string nPass){
            canil.editarEmail(email,novoEmail);
        }
        void adicionarCao(string emailC,char genero, string nome, string cor, string raca, int idade, string descricao){
            int caoId = caes.adicionarCao(genero, nome, cor, raca, idade, descricao);
            canil.adicionarCao(emailC, caoID);
        }
        void adicionarCanil(string nome, string email, string password, int cap, string morada, int tel, int nib){
            canis.adicionarCanil(nome, email, password, cap, morada, tel, nib);
        }
        void adicionarParceria(string emailC, string nome, string info){
            canis.adicionarParceria(emailC, nome, info);
        }
        void adicionaHorario(string emailC, DateTime horarioI, DateTime horarioF){
            canis.adicionarHorario(emailC, horarioI, horarioF);
        }
        void registaHorario(string emailC, string emailV, DateTime horarioI, DateTime horarioF){
            canis.adicionarCanil(emailC, emailV, horarioI, horarioF);
        }
        void favoritarCao(string email, int caoID){
            utilizador.favoritarCao(email, caoID);
        }
        void adotarCao(string email, int caoID){
            utilizador.adotarCao(email, caoID);
            caes.adotarCao(caoID);
        }
        void removerUtilizador(string email){
            utilizadores.removerUtilizador(email);
        }
        void removerCao(string emailC,int caoID){
            canil.removerCao(emailC, caoID);
            caes.removerCao(caoID);
        }
        void removerCanil(string email){
            canis.removerCanil(email);
        }
        void removerParceria(string emailC, string nome){
            canis.removerParceria(emailC, nome);
        }
        void desmarcaHorario(string emailC, string emailV, DateTime horarioI, DateTime horarioF){
            canis.desmarcaHorario(emailC, nome, horarioI, horarioF);
        }
        void removeHorario(string emailC, DateTime horarioI, DateTime horarioF){
            canis.removeHorario(emailC, horarioI, horarioF);
        }
        void pesquisaCanil(string local){
            canils.canisProximos(local);
        }
        void pesquisaCao(string raca, int idade, string local){
            canils.pesquisaCao(local);
        }
        void pesquisaCao(string raca, int idade, char sexo, string cor, char porte, string local){
            canils.pesquisaCao(raca, idade, sexo, cor, porte, local);
        }
        void pesquisaCaoCanil(string raca, int idade, char sexo, string cor, char porte, string emailC){
            canils.pesquisaCaoCanil(raca, idade, sexo, cor, porte, emailC);
        }
    }
}