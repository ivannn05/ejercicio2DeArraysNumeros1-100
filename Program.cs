namespace ejercicio2DeArraysNumeros;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("---------------------");
        int[,] matriz = new int[10, 10];

        //Hacer la matriz del 100 al 1
        int numeros = 100;
        for (int i = 0; i < 10; i++)
        {

            for (int j = 0; j < 10; j++)
            {

                matriz[i, j] = numeros;
                numeros--;

              
            }
           
        }

        for (int i = 0; i < 10; i++)
        {
            
            for (int j = 0; j < 10; j++)
            {
                Console.Write(matriz[i, j] + " " );
            }
            Console.WriteLine("|");
        }

        Console.WriteLine("---------------------");
        //Imprimir los numeros 
        for (int i = 0;i <= 100; i++)
        {
            Console.WriteLine(i);
        }
    }
}

    
