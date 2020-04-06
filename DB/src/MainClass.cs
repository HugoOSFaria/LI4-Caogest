using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoGest.src
{
    class MainClass
    {
        public static void Main()
        {
            //canilDB.insereCanil(""random@gmail.com", "192888494", "Novo Canil", 10, 25, "minhapass", "porto", "Rua do teste","Lousada","912839913");

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
