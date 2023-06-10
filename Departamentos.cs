namespace Departamentos
{
    public class depto
    {
        public string Name {get; set;}
        public int population {get;set;}

        public depto(String n, int poblacion)
        {
            Name = n;
            population = poblacion;
        }
    }
}