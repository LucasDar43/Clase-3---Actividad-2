namespace actividad2
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Ingrese el valor de a: ");
                double a;

                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Ingrese un valor numérico válido para a: ");
                }

                Console.WriteLine("Ingrese el valor de b: ");
                double b;

                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Ingrese un valor numérico válido para b: ");
                }

                Console.WriteLine("Ingrese el valor de c: ");
                double c;

                while (!double.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Ingrese un valor numérico válido para c: ");
                }



                double discriminante = Math.Pow(b, 2) - 4 * a * c;

                if (discriminante > 0)
                {

                //Si el discriminante es mayor que cero (> 0), entonces la ecuación tiene dos
                //raíces reales y distintas.
                double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                    double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                    Console.WriteLine("Las raíces son: " + raiz1.ToString("0.00") + " y " + raiz2.ToString("0.00"));
                }
                else if (discriminante == 0)
                //Si el discriminante es igual a cero (== 0), entonces la
                //ecuación tiene una única raíz real.
                {
                double raiz = -b / (2 * a);
                    Console.WriteLine("La raíz es: " + raiz.ToString("0.00"));
                }
                else
                {
                //si el discriminante es menor que cero(< 0), entonces la ecuación
                //tiene dos raíces complejas conjugadas.
                    double parteReal = -b / (2 * a);
                    double parteImaginaria = Math.Sqrt(-discriminante) / (2 * a);
                    Console.WriteLine("Las raíces son complejas: " + parteReal.ToString("0.00") + " + " + parteImaginaria.ToString("0.00") + "i y " + parteReal.ToString("0.00") + " - " + parteImaginaria.ToString("0.00") + "i");
                }

                Console.WriteLine("Gracias por utilizar el programa para calcular las raíces de una ecuación de segundo grado. ¡Hasta luego!");
        }
        
    }
}
