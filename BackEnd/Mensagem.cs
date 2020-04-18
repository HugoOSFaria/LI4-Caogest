using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LI4BackEnd
{
    class Mensagem
    {
        // Atributos
        private int tipo;
        private List<Canil> canis;
        private List<User> utilizadores;
        private List<Cao> caes;

        // Declarador por omissão
        public Mensagem()
        {
            tipo = 0;
            canis = new List<Canil>();
            utilizadores = new List<User>();
            caes = new List<Cao>();
        }

        // Declarador por parâmetros
        public Mensagem(int type, List<Canil> cans, List<User> utils, List<Cao> cs)
        {
            tipo = type;
            canis = new List<Canil>();
            foreach(Canil can in cans)
            {
                canis.Add(new Canil(can));
            }
            utilizadores = new List<User>();
            foreach(User u in utils)
            {
                utilizadores.Add(new User(u));
            }
            caes = new List<Cao>();
            foreach(Cao c in cs)
            {
                caes.Add(new Cao(c));
            }
        }

        // Declarador por cópia
        public Mensagem(Mensagem m)
        {
            tipo = m.getTipo();
            canis = new List<Canil>();
            foreach (Canil can in m.getCanis())
            {
                canis.Add(new Canil(can));
            }
            utilizadores = new List<User>();
            foreach (User u in m.getUtilizadores())
            {
                utilizadores.Add(new User(u));
            }
            caes = new List<Cao>();
            foreach (Cao c in m.getCaes())
            {
                caes.Add(new Cao(c));
            }
        }

        // Métodos de acesso a atributos
        public int getTipo()
        {
            int type = tipo;
            return type;
        }

        public List<Canil> getCanis()
        {
            List<Canil> cans = new List<Canil>();
            foreach(Canil can in canis)
            {
                cans.Add(new Canil(can));
            }
            return cans;
        }

        public List<User> getUtilizadores()
        {
            List<User> users = new List<User>();
            foreach (User u in utilizadores)
            {
                users.Add(new User(u));
            }
            return users;
        }

        public List<Cao> getCaes()
        {
            List<Cao> cs = new List<Cao>();
            foreach (Cao c in caes)
            {
                cs.Add(new Cao(c));
            }
            return cs;
        }

        // Métodos de esctrita de atributos

        public void setTipo(int type)
        {
            tipo = type;
        }

        public void setCanis(List<Canil> cans)
        {
            canis = new List<Canil>();
            foreach(Canil c in cans)
            {
                canis.Add(new Canil(c));
            }
        }

        public void setUtilizadores(List<User> utils)
        {
            utilizadores = new List<User>();
            foreach(User u in utils)
            {
                utilizadores.Add(new User(u));
            }
        }

        public void setCaes(List<Cao> cs)
        {
            caes = new List<Cao>();
            foreach(Cao c in cs)
            {
                caes.Add(new Cao(c));
            }
        }

        // Métodos de conversão de e para objecto/JSon
        public void loadMensagem(string filename)
        {
            Mensagem msg = new Mensagem();

            // método de conversão infromação em formato jso para um objecto java;
            // Nota: nomes de atributos em json devem ser iguais aos nomes dos atributos do objeto java;
            msg = JsonConvert.DeserializeObject<Mensagem>(filename);

            this.setCanis(msg.getCanis());

            this.setUtilizadores(msg.getUtilizadores());

            this.setCaes(msg.getCaes());

        }

        // Cria uma string compatível com json contendo informação relativa a uma mensagem;
        public string saveMensagem(int type, List<Canil> cans, List<User> utils, List<Cao> cs)
        {
            // Criação de uma mensagem com os dados pretendidos para escrita posterior
            Mensagem msg = new Mensagem(type, cans, utils, cs);

            // Método de conversção de um objecto para uma string compatível com json.
            string json = JsonConvert.SerializeObject(msg);

            return json;
        }
    }
}
