using System;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {   
        //mesCorrespondente();
        //mediaSimples();
        //parOuImpar();
        //inverterString();
        //substituirCaracteres();
        primeiroValorNaoRepetido();
        //ordernarArray();
    }

    static void mesCorrespondente(){
        Console.WriteLine("Digite um número de 1 a 12");
        //string numero = Console.ReadLine() ?? "";
        string numero  = "10";

        switch (numero) {
            case "1":
                System.Console.WriteLine($"{numero} - Janeiro");
                break;

            case "2":
                System.Console.WriteLine($"{numero} - Fevereiro");
                break;

            case "3":
                System.Console.WriteLine($"{numero} - Março");
                break;

            case "4":
                System.Console.WriteLine($"{numero} - Abril");
                break;

            case "5":
                System.Console.WriteLine($"{numero} - Maio");
                break;

            case "6":
                System.Console.WriteLine($"{numero} - Junho");
                break;

            case "7":
                System.Console.WriteLine($"{numero} - Julho");
                break;

            case "8":
                System.Console.WriteLine($"{numero} - Agosto");
                break;

            case "9":
                System.Console.WriteLine($"{numero} - Setembro");
                break;

            case "10":
                System.Console.WriteLine($"{numero} - Outubro");
                break;

            case "11":
                System.Console.WriteLine($"{numero} - Novembro");
                break;

            case "12":
                System.Console.WriteLine($"{numero} - Dezembro");
                break;
            
            case "":
                System.Console.WriteLine("Insira algum valor");
                break;

            default:
                System.Console.WriteLine($"{numero} não é válido, informe um número de 1 a 12");
                break;
        }
    }

    static void mediaSimples(){
        int[] numeros = new int[3];
        numeros[0] = 10;
        numeros[1] = 20;
        numeros[2]= 30;

        float media = 0;
        int soma = 0;
        bool falso = false;

        if (numeros.Length < 2)
        {
            System.Console.WriteLine(falso);
        }
        else
        {
            for(int contador = 0; contador < numeros.Length; contador++)
            {
                soma += numeros[contador];
            }
            media = soma / numeros.Length;
        System.Console.WriteLine(media);
        }
    }

    static void parOuImpar(){
        int[] numeros = new int[5];
        numeros[0] = 1;
        numeros[1] = 2;
        numeros[2] = 3;
        numeros[3] = 4;
        numeros[4] = 5;

        int contadorPar = 0;
        int teste = 0;

        for(int contador = 0; contador < numeros.Length; contador++)
        {
            teste = numeros[contador] % 2;

            if(teste == 0){
                contadorPar++;
            }
        }
        System.Console.WriteLine(contadorPar);
    }

    static void inverterString(){
        string texto = "bar";

        for(int contador = texto.Length - 1; contador >= 0; contador-- )
        {
            System.Console.Write(texto[contador]);
        }
        System.Console.WriteLine();
    }

    static void substituirCaracteres() {
        string texto = "bar";
        string novoTexto = "";

        for(int contador = 0; contador < texto.Length; contador++) 
        {
            if(texto[contador] == 'A' || texto[contador] == 'a' || texto[contador] == 'E' || texto[contador] == 'e' || texto[contador] == 'I' || texto[contador] == 'i' || 
            texto[contador] == 'O' || texto[contador] == 'o' || texto[contador] == 'U' || texto[contador] == 'u')
            {
                novoTexto += '?';
            }
            else
            {
                novoTexto += texto[contador];
            }
        }
    System.Console.WriteLine(novoTexto);
    System.Console.WriteLine();
    }

    static void ordernarArray(){
        int[] lista = new int[8];
        lista[0] = 3;
        lista[1] = 1;
        lista[2] = 0;
        lista[3] = 2;
        lista[4] = 2;
        lista[5] = 9;
        lista[6] = 10;
        lista[7] = 7;

        for (int i = 0; i < lista.Length - 1; i++) 
        {

            for (int j = 0; j < lista.Length - 1 - i; j++) 
            {
                if (lista[j] > lista[j + 1]) 
                {

                int armazenador = lista[j];
                lista[j] = lista[j + 1];
                lista[j + 1] = armazenador;

                }
            }
        }

        for(int contador = 0; contador < lista.Length; contador++)
        {
            System.Console.Write($"{lista[contador]} ");
        }
    }

    static void primeiroValorNaoRepetido() {

        int[] input = new int[7];
        input[0] = 10;
        input[1] = 3;
        input[2] = 10;
        input[3] = 4;
        input[4] = 5;
        input[5] = 3;
        input[6] = 7;

        

        for(int contador1 = 0; contador1 < input.Length; contador1++)
        {
            int teste = 0;

            for(int contador2 = 0; contador2 < input.Length; contador2++)
            {
                if(input[contador1] == input[contador2])
                {
                    teste++;
                }
                
            }   
            if (teste == 1)
            {
                System.Console.WriteLine(input[contador1]);
                return;
            }
        }
        


    }

    static void manipulacaoArquivo() {

    }

    static void encontrarNumeroCartao() {

    }

    static void menorNumeroNotas() {

    }

}