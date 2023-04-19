using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPR21BM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuzin;
            Console.WriteLine("1- exercicio 1");
            Console.WriteLine("2- exercicio 2");
            Console.WriteLine("3- exercicio 3");
            Console.WriteLine("4- exercicio 4");
            Console.WriteLine("5- exercicio 5");
            Console.WriteLine("6- exercicio 6");
            Console.WriteLine("7- exercicio 7");
            menuzin = int.Parse(Console.ReadLine());

            switch (menuzin)
            {
                case 1:
                    int abso, tabso=0;
                    Console.WriteLine("digite um numero qualquer");
                    abso = int.Parse(Console.ReadLine());

                    if (abso > 0)
                        Console.WriteLine(abso);
                    else
                        tabso = abso * -1;
                        Console.WriteLine(tabso);

                    break;
                case 2:
                    int numero, t;
                    Console.WriteLine("digite um numero qualquer:");
                    numero = int.Parse(Console.ReadLine());

                    // fazer o multiplo

                    
                    if ( numero%3==0 && numero%4==0 && numero%5==0 && numero%7==0)
                        Console.WriteLine(" seu numero é divisivel por 3,4,5,7");
                    else if ( numero%3==0 || numero%4==0 && numero%5==0 && numero%7==0)
                        Console.WriteLine(" seu numero é divisivel por 3,4,5,7");



                    


                    break;
                case 3:
                    break;
                case 4:
                    int dias;
                    Console.WriteLine("digite um numero de 1 a 7 condiderando os dias da semana:");
                    dias = int.Parse(Console.ReadLine());
                    switch (dias)
                    {
                        case 1:
                            Console.WriteLine("o dia é referente a domingo");
                            Console.WriteLine("gosto de descansar");
                            break;

                        case 2:
                            Console.WriteLine("segunda");
                            Console.WriteLine("filosofia, matematica e portugues");
                            break;
                        case 3:
                            Console.WriteLine("terça");
                            Console.WriteLine("quimica, matematica e portugues ");
                            break;
                        case 4:
                            Console.WriteLine("quarta");
                            Console.WriteLine("biologia, portugues e programaçao");
                            break;
                        case 5:
                            Console.WriteLine("quinta");
                            Console.WriteLine("sociologia, fisica e redes");
                            break;
                        case 6:
                            Console.WriteLine("sexta");
                            Console.WriteLine("geografia, matematica e banco de dados");
                            break;
                        case 7:
                            Console.WriteLine("sabado");
                            Console.WriteLine("aos sabados gosto de sair para algum lugar legal.");
                            break;
                            
                        default:
                            Console.WriteLine("dia invalido");
                            break;
                    }
                    
                    break;
            
                case 5:

                    int maior , menor, nums;
                  
                    for (int i = 1; i != 0; i++)
                    {
                       


                        Console.WriteLine(" digite um numero, quando desejar para digite 0:");
                        nums = int.Parse(Console.ReadLine());

                        maior = nums;
                        menor = nums;


                        if (nums > maior && nums < menor)
                            Console.WriteLine("numero maior: " + maior + "numero menor: " + menor);

                    }
                    
                   


                    break;
                case 6:
                    break;
                case 7:
                    float notas=0;
                    for (int i = 0; i != 0; i++)
                    {
                        Console.WriteLine("digite as notas:");
                        notas = float.Parse(Console.ReadLine());
                        
                       
                    }
                    break;

                    default:
                    Console.WriteLine("exercico invalido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
