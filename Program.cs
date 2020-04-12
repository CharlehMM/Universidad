using System;

namespace prueba
{
    class Program
    {
        static float[] nota;
        static float numero;

        static void Main(string[] args)
        {
            ingresarNotas();
            notaMenor();
            notaMayor();
            promedio();
        } 

        public static void  ingresarNotas()
        {
            Console.Write("Cuantas notas desea ingresar:");
            string linea;
            linea = Console.ReadLine();
            int n=int.Parse(linea);
            nota=new float[n];
            for (int i = 0; i < nota.Length; i++)
            {
                Console.Write("Ingrese la "+(i+1)+"° nota:");
                numero = Convert.ToSingle(Console.ReadLine());
                nota[i]=numero;
            }
                
        }

        public static void notaMenor() 
        {
            float min = nota[0];
            for (int i = 0; i < nota.Length; i++)
            {
                if (nota[i]<min)
                {
                    min=nota[i];
                }
            }
            Console.WriteLine("la nota menor: "+min);     
        }

        public static void notaMayor() 
        {
            float max = nota[0];
            for (int i = 0; i < nota.Length; i++)
            {
                if (nota[i]>max)
                {
                    max=nota[i];
                }
            }
            Console.WriteLine("La nota mayor es: "+max);     
        }

        public static void promedio() 
        {
            float suma = 0;
            float prom = 0;
            for (int i = 0; i < nota.Length; i++)
            {
                suma+=nota[i];
            }
            prom = suma/nota.Length;
            Console.WriteLine("El promedio de las notas es: "+prom);
        }

    }
}
