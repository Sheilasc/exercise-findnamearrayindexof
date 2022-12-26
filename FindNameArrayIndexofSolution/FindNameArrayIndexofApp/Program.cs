internal class Program
{
    private static void Main(string[] args)
    {
        string[] ArrayOfNames = new string[5]  { "Emi", "Sheila", "Pablo", "Juan","Jose" };
  
       //Funcion Imprimir el arreglo
       ImprimirArray(ArrayOfNames,5);

       //Ingresar el nombre a buscar
       Console.WriteLine("Ingrese el nombre que quiere buscar: ");
       string name = Console.ReadLine();

       //Funcion Buscar en el arreglo
        Buscar(ArrayOfNames, name); 
    }

    //funcion Imprimir
      public static void ImprimirArray(string[] array, int tamanio)
      {
          for (int i = 0; i < tamanio; i++)
          {
              Console.WriteLine("Array posicion: " + i + " Valor: " + array[i]);
          }
      }

    //funcion buscar el nombre en el arreglo
      public static void Buscar(string[] array, string n)
      {
       int posicion = Array.IndexOf(array, n);
        if (posicion == -1)
        {
          Console.WriteLine("El nombre  " +n+ " no existe en el arreglo.");
        }
        else
        {
          Console.WriteLine(n + "  esta en la posicion:  "+posicion);
        }
      }  
}