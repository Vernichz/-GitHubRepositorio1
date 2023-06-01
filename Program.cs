using System.Collections;
//definición e inicialización de los arreglos en paralelo y el diccionario 
String[] Departamento = { "Boaco", "Carazo", "Chinandega", "Chontales", "Costa Caribe Norte", "Costa Caribe Sur", "Estelí", "Granada", "Jinotega", "León", "Madriz", "Managua", "Masaya", "Matagalpa", "Nueva Segovia", "Río San Juan", "Rivas" };
int[] Poblacion = { 185013, 197139, 439906, 190863, 530586, 414543, 229866, 214317, 475630, 421050, 174744, 1575819, 391903, 593503, 271581, 135446, 182645 };
Dictionary<string, int> diccionario = Departamento
          .Zip(Poblacion, (k, v) => new { Clave = k, Valor = v })
          .ToDictionary(x => x.Clave, x => x.Valor);
//Encontrar el mayor y el menor
int maxDep = Poblacion.Max();
int minDep = Poblacion.Min();
string maxDepkey = "",minDepkey=";
for (var i = 0; i < Poblacion.Length; i++)
{
    if (Poblacion[i] == maxDep)
        maxDepkey = Departamento[i]
    if (Poblacion[i] == minDep)
        minDepkey = Departamento[i]
}
//mostrar diccionario sin ordenar
Console.WriteLine($"datos Desorddenados");
foreach (var item in diccionario)
   Console.WriteLine($"{item.Key, -20}==>{item.Value, 10:NO}");
   Console.WriteLine();
//Ordenado con LINQ OrdeBy el diccionario
for (var i=0; i<Poblacion.Length; i++)
     Console.WriteLine($"{Departamento[i], 20} ==> {Poblacion[i], 10:NO}");
//Sumar las poblaciones con SUM de LINQ
Console.WriteLine($"Población General:{diccionario.Values.Sum():NO}");
Console.WriteLine($"Departamento con mayor población: {maxDepkey}");
Console.WriteLine($"Departamento con menor Población: {minDepkey}");
