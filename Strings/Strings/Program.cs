using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder();
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
            Console.WriteLine(texto2.Contains("Teste"));           // aq vai ser falso pq o T ta mauisculo

           // Console.WriteLine(texto2.Contains("Teste", StringComparison.OrdinalIgnoreCase)); // aq ele ignora o sensitivecase
                         //entao tanto faz se o t ta mauisculo ou minusculo. assim q ignora o case sensitive



            //contains é para ver se tem algo na string e compare to é para comparar o resultado, ele retorna a quantia
            //de resultados que ha na string. ( ele usa o 0 1 2 3 4 5) e o contains retorna true or false
        }               

        //starts with / ends with
        static void Swew()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto);
            // o starts with retorna um booleano assim como o endwith. nesse caso o SW é basicamente COMECA COM
            Console.WriteLine(texto.StartsWith("este"));    //falso pq comeca com E maiusculo
            Console.WriteLine(texto.StartsWith("Este"));    //true
            Console.WriteLine(texto.StartsWith("texto"));   //falso pq n comeca com a palavra texto
            Console.WriteLine("\n\n\n");
            Console.WriteLine(texto.EndsWith("Teste"));
            Console.WriteLine(texto.EndsWith("teste"));     //ends with é basicamente TERMINA COM
            Console.WriteLine(texto.EndsWith("eliel"));


        }

        //equals
        static void Equals()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));


        }

        //indices no array
        static void Indices()
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.IndexOf("é")); //isso busca dentro do array(texto/string) a
                                                   //posicao do caracter

            Console.WriteLine(texto.IndexOf("um"));
            Console.WriteLine(texto.LastIndexOf("s")); //ultima posicao que o caracter aparece
        }

        //Metodos adicionais toupper tolower etc
        static void Metodos()
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.ToLower()); //deixa tudo minusculo
            Console.WriteLine(texto.ToUpper()); //deixa tudo maiusculo
            Console.WriteLine(texto.Insert(5,"AQUI ")); //vai inserir isso no texto
            //ele pede primeiro o lugar onde o texto vai entrar e dps o texto
            Console.WriteLine(texto.Remove(5, 5)); // o oposto do de cima
            Console.WriteLine(texto.Length); //da o tamanho em INT do array/string

            //manipulando strings



        }

        //manipulano string
        static void ManipulandoStrings()
        {
            //replace
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Replace("Este", "isto")); //troca o este por isto
            Console.WriteLine(texto.Replace("e", "X")); //funciona pro texto todo como aq

                                                //split
            //var divisao = texto.Split("e");
            //Console.WriteLine(divisao[0]);
            //  Console.WriteLine(divisao[1]);
            //Console.WriteLine(divisao[2]);            //tudo bug
            // Console.WriteLine(divisao[3]);


            var resultado = texto.Substring(5, 5);
            Console.WriteLine(resultado);
            
            var resultado2 = texto.Substring(5, texto.LastIndexOf("o"));
            Console.WriteLine(resultado2);

            Console.WriteLine(texto.Trim()); //remove os espacos do 1 e do ultimo caracter
            //normalmente usado para quando vamos fazer um formulario e tal pra alguem preencher um email
            //por exemplo, e o imbecil sem querer coloca ESPACO no comeco; ai o TRIM remove isso ja. TOP
        }

        //string builder
        static void StringBuilder()
        {
            var texto = "Este texto é um teste ne";
            texto += " pai"; //concatenando a stringo hehe

            //mas isso nao é legal isso pode sobrecarregar a memoria caso for um texto gigante tlgd
            //agora para criar as linhas dinamicas pode usar o @ que quebra a linha igual daquele jeito
            //pórem a melhor forma de fz isso é usando o append igual agr ehehehhehehehe

            var texto2 = new StringBuilder(); // ele ja ta dentro do using System.Text

            texto2.Append("Este texto é um teste. ");
            texto2.Append("!O eliel é muito inteligente ");
            texto2.Append("kkkkkkkkkkkkkkk");

            Console.WriteLine(texto2);
        }

    }
}
