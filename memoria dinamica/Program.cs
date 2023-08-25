Console.Write("Ingrese el tamaño de la lista: ");
int n = Convert.ToInt32(Console.ReadLine());

List<int> lista = new List<int>();

Console.WriteLine("Ingrese los elementos de la lista:");
for (int i = 0; i < n; i++)
{
    Console.Write($"Elemento {i + 1}: ");
    int elemento = Convert.ToInt32(Console.ReadLine());
    lista.Add(elemento);
}

Console.WriteLine("Los elementos ingresados son:");
foreach (int elemento in lista)
{
    Console.Write(elemento + " ");
}
Console.WriteLine();
