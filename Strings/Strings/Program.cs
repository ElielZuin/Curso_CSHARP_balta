using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comparacao();
        }
        
        //guids
        static void Guids()
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("9a4a70a1-bc25-4a3a-aae1-65730e10a27c");
            Console.WriteLine(id);
            Console.WriteLine(id.ToString().Substring(0, 8));
        }

       //interpolacao de strings
        static void Interpolacao()
        {
            var price = 10.2;   //aq ele e um double
            var texto = "O preço do produto é " + price + " apenas na promocao"; //aq como ele foi concatenado,
                                                                                //o 10.2 se transforma em string
            Console.WriteLine(texto);

            var text = string.Format("O preço do produto é {0} apenas na promoção.", price); //ele vai mudar o {0}
            Console.WriteLine(text);    // para os valores que estao depois da virgula. o apos seria {1} e o prox
                                        // var dps da virgula. não importa a ordem, por exemplo; {3} {1} {0} {2}
                                        // ele vai pegar na sequencia das variavel q estao depois da virgula
                                        // na sua respectiva ordem, comecada por 0,1,2,3,4,5,6,7...
                                        // ção.", price, true, false, eliel);

            var textum = $"O preço do produto é {price} so na promo";   // outra forma de concatenar dentro da var
            Console.WriteLine(textum);


            var text1 = $@"O preço do produto       
                         é {price} so na \n promociones";    // o @ serve pra mudar a linha na var desse jeitinho ai
                                                             // mas ele ja ignoraria o \n

            Console.WriteLine(text1);
        }

        //comparacao de strings
        static void Comparacao()
        {
            var texto = "Testando";

            Console.WriteLine(texto.CompareTo("Testando"));    // retorna um inteiro (1 ou 0) nesse caso 0
            Console.WriteLine(texto.CompareTo("testando"));     // nesse caso 1 pq ele é case sensitive.o T ta minusculo

            var texto2 = "Este texto é um teste?";

            Console.WriteLine(texto2.Contains("teste"));        //aq retorna um booleano, no caso como tem
                                                                // a palavra teste na string, vai ser true
            Console.WriteLine(texto2.Contains("Teste"));        // aq vai ser falso pq o T ta mauisculo
        }
    }
}
