using System.Collections;
//definición e inicialización de los arreglos en paralelo y el diccionario 
String[] Departamento = { "Boaco", "Carazo", "Chinandega", "Chontales", "Costa Caribe Norte", "Costa Caribe Sur", "Estelí", "Granada", "Jinotega", "León", "Madriz", "Managua", "Masaya", "Matagalpa", "Nueva Segovia", "Río San Juan", "Rivas" };
int[] Poblacion = { 185013, 197139, 439906, 190863, 530586, 414543, 229866, 214317, 475630, 421050, 174744, 1575819, 391903, 593503, 271581, 135446, 182645 };
Dictionary<string, int> diccionario = Departamento
          .Zip(Poblacion, (k, v) => new { Clave = k, Valor = v })
          .ToDictionary(x => x.Clave, x => x.Valor);
//Ordenado el diccionario de menor a mayor
var ordenado = diccionario.OrderBy(x=>x.Value).ToDictionary(x=>x.Key, x=>x.Value);
//fijando los nombres de los departamentos con menor y mayor población
string minDepkey = ordenado.First().Key;
string maxDepkey = ordenado.Last().Key;
//reasignacion de los arreglos en paralelo
Departamento = ordenado.Keys.ToArray();
Poblacion = ordenado.Values.ToArray();
//Mostrar el diccionario sin ordenar
for (var i = 0; i < Poblacion.Length; i++)
    Console.WriteLine($"{Departamento[i],20} ==> {Poblacion[i], 10:NO}");
Console.WriteLine($"datos Desorddenados");
foreach (var item in diccionario)
Console.WriteLine($"{item.Key, -20}==>{item.Value, 10:NO}");
Console.WriteLine();
//Ordenado con LINQ OrdeBy el diccionario
