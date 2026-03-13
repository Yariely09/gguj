namespace ejercicio_estudiante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("=== SISTEMA DE ESTUDIANTES ===");

            Estudiante[] lista = new Estudiante[5];

            // Ciclo para leer los 5 estudiantes
            for (int i = 0; i < 5; i++)
            {
                lista[i] = new Estudiante();
                Console.WriteLine("\nDatos del Estudiante #" + (i + 1));
                lista[i].Leer();
            }

            Console.WriteLine("\n=== LISTA FINAL DE ESTUDIANTES ===");
            // Ciclo para mostrar los 5 estudiantes
            for (int i = 0; i < 5; i++)
            {
                lista[i].Mostrar();
            }

            Console.ReadKey();
        }
    }

    class Estudiante
    {
        public string matricula;
        public string nombre;
        public int edad;
        public string carrera;

        public void Leer()
        {
            Console.Write("Matricula: ");
            matricula = Console.ReadLine();
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Carrera: ");
            carrera = Console.ReadLine();
        }

        public void Mostrar()
        {
            Console.WriteLine("ID: " + matricula + " | Nombre: " + nombre + " | Carrera: " + carrera);
        }
    }
}
        
    

