using System;
using System.Linq;

try
{
void matriz()
{
    int num;

    Console.Write("Cuantos alumnos tendra el arreglo?: ");
    num = Convert.ToInt32(Console.ReadLine());

    String [] nombre = new String[num];
    int[] notas = new int[num];


    for (int i = 0; i < num; i++)
    {
        Console.Write($"Alumno {i+1}: ");
        nombre[i] = Console.ReadLine();

        Console.Write($"Nota: ");
        notas[i] = Convert.ToInt32(Console.ReadLine());
    }


    foreach (var pair in nombre.Zip(notas, (x,y) => (x,y)))
    {
    Console.WriteLine($"Nombre: {pair.x.PadRight(20)}  Nota: {pair.y.ToString().PadLeft(3)}");
    }
    

    
    int promedio = 0;
    foreach(int n in notas)
    {
        promedio=promedio+n;
    }
    
    promedio = promedio / notas.Length;
    Console.WriteLine($"Promedio de notas: {promedio}");

    int mayor = 0, menor = 100;
    string nombredemayor="", nombredemenor="";

    for (int i = 0; i < notas.Length; i++)
    {
        if (mayor < notas[i])
        {
            mayor = notas[i];
            nombredemayor = nombre[i];
        }
    }

        for (int i = 0; i < notas.Length; i++)
    {
        if (menor > notas[i])
        {
            menor = notas[i];
            nombredemenor = nombre[i];
        }
    }

    Console.WriteLine($"Mejor nota: {nombredemayor} con {mayor}");
    Console.WriteLine($"Nota mas baja: {nombredemenor} con {menor}");
}

matriz();

}
catch 
{
    Console.Write("Ingresa datos validos");
}