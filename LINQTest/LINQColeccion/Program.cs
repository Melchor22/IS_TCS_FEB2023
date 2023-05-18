using LINQColeccion;
using System.Linq;
/*int[] Numeros = new int[] {1,2,3,4,5,6,7,8,9,10};
Console.WriteLine("A continuación se muestran los numeros pares del arreglo.");
List<int> NumerosPares = new List<int>();
foreach (int Numero in Numeros)
{
    if (Numero % 2 == 0)
    {
        NumerosPares.Add(Numero);
    }
}

foreach (int Numero in NumerosPares)
{
    Console.WriteLine(Numero);
}

Console.WriteLine();

IEnumerable<int> NumerosParesLINQ = from numero in Numeros where numero % 2 == 0 select numero;

foreach (int Numero in NumerosParesLINQ)
{
    Console.WriteLine(Numero);
}*/

ControlAlumnos controlAlumnos =  new ControlAlumnos();
controlAlumnos.obtenerAlumnosPorCarrera(2);