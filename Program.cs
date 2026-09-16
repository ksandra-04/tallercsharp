using System;

// Este programa junta los 15 ejercicios del taller.
// Al ejecutarlo se muestra un menú y el usuario elige cuál quiere probar.

class Program
{
    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine();
            Console.WriteLine("===== MENU DEL TALLER =====");
            Console.WriteLine("1. Positive Power");
            Console.WriteLine("2. Double or Triple");
            Console.WriteLine("3. Root or Square");
            Console.WriteLine("4. Circle Perimeter");
            Console.WriteLine("5. Midweek Day");
            Console.WriteLine("6. Tax Calculator");
            Console.WriteLine("7. Remainder Finder");
            Console.WriteLine("8. Sum of Evens");
            Console.WriteLine("9. Fraction Difference");
            Console.WriteLine("10. String Length");
            Console.WriteLine("11. Average of Four");
            Console.WriteLine("12. Smallest of Five");
            Console.WriteLine("13. Vowel Counter");
            Console.WriteLine("14. Factorial Finder");
            Console.WriteLine("15. InRange Validator");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opcion: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": PositivePower(); break;
                case "2": DoubleOrTriple(); break;
                case "3": RootOrSquare(); break;
                case "4": CirclePerimeter(); break;
                case "5": MidweekDay(); break;
                case "6": TaxCalculator(); break;
                case "7": RemainderFinder(); break;
                case "8": SumOfEvens(); break;
                case "9": FractionDifference(); break;
                case "10": StringLength(); break;
                case "11": AverageOfFour(); break;
                case "12": SmallestOfFive(); break;
                case "13": VowelCounter(); break;
                case "14": FactorialFinder(); break;
                case "15": InRangeValidator(); break;
                case "0": salir = true; break;
                default: Console.WriteLine("Opcion invalida."); break;
            }
        }
    }

    // 1. Positive Power
    // Pide un numero y si es positivo muestra su cuadrado.
    static void PositivePower()
    {
        Console.Write("Ingresa un numero: ");
        int numero = int.Parse(Console.ReadLine());

        // Reviso si el numero es mayor a cero antes de elevarlo al cuadrado
        if (numero > 0)
        {
            int resultado = numero * numero;
            Console.WriteLine("Resultado: " + resultado);
        }
        else if (numero < 0)
        {
            Console.WriteLine("Numero negativo.");
        }
        else
        {
            Console.WriteLine("0");
        }
    }

    // 2. Double or Triple
    // Compara dos numeros: si el primero es mayor devuelve su doble,
    // si no devuelve el triple del segundo.
    static void DoubleOrTriple()
    {
        Console.Write("Ingresa el primer numero: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo numero: ");
        double numero2 = double.Parse(Console.ReadLine());

        // Comparo cual de los dos numeros es mayor para decidir la operacion
        if (numero1 > numero2)
        {
            Console.WriteLine("Resultado: " + (numero1 * 2));
        }
        else
        {
            Console.WriteLine("Resultado: " + (numero2 * 3));
        }
    }

    // 3. Root or Square
    // Si el numero es positivo devuelve su raiz cuadrada, si no, su cuadrado.
    static void RootOrSquare()
    {
        Console.Write("Ingresa un numero: ");
        double numero = double.Parse(Console.ReadLine());

        // Si el numero es positivo calculo raiz, de lo contrario calculo el cuadrado
        if (numero > 0)
        {
            Console.WriteLine("Resultado: " + Math.Sqrt(numero));
        }
        else
        {
            Console.WriteLine("Resultado: " + (numero * numero));
        }
    }

    // 4. Circle Perimeter
    // Calcula el perimetro de un circulo: 2 * pi * radio
    static void CirclePerimeter()
    {
        Console.Write("Ingresa el radio: ");
        double radio = double.Parse(Console.ReadLine());

        // Formula del perimetro: 2 multiplicado por pi multiplicado por el radio
        double perimetro = 2 * Math.PI * radio;
        Console.WriteLine("Resultado: " + Math.Round(perimetro, 2));
    }

    // 5. Midweek Day
    // Muestra el nombre del dia solo si es un dia laboral (1 a 5).
    static void MidweekDay()
    {
        Console.Write("Ingresa un numero del 1 al 7: ");
        int dia = int.Parse(Console.ReadLine());

        // Solo muestro el dia si esta entre 1 y 5 (dias laborales)
        if (dia == 1) Console.WriteLine("Lunes");
        else if (dia == 2) Console.WriteLine("Martes");
        else if (dia == 3) Console.WriteLine("Miercoles");
        else if (dia == 4) Console.WriteLine("Jueves");
        else if (dia == 5) Console.WriteLine("Viernes");
        else Console.WriteLine("Numero fuera del rango laboral.");
    }

    // 6. Tax Calculator
    // Si el salario supera 12000, calcula el 15% del excedente.
    static void TaxCalculator()
    {
        Console.Write("Ingresa el salario anual: ");
        double salario = double.Parse(Console.ReadLine());

        // El impuesto solo aplica si el salario supera los 12000
        if (salario > 12000)
        {
            double excedente = salario - 12000;
            double impuesto = excedente * 0.15;
            Console.WriteLine("Resultado: " + impuesto);
        }
        else
        {
            Console.WriteLine("No debe impuestos.");
        }
    }

    // 7. Remainder Finder
    // Muestra el residuo (lo que sobra) de dividir dos numeros.
    static void RemainderFinder()
    {
        Console.Write("Ingresa el primer numero: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo numero: ");
        int numero2 = int.Parse(Console.ReadLine());

        // El simbolo % me da el residuo (lo que sobra) de la division
        int residuo = numero1 % numero2;
        Console.WriteLine("Resultado: " + residuo);
    }

    // 8. Sum of Evens
    // Suma todos los numeros pares entre 1 y 50.
    static void SumOfEvens()
    {
        int suma = 0;

        // Recorro los numeros del 1 al 50 y sumo solo los pares
        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 == 0)
            {
                suma = suma + i;
            }
        }

        Console.WriteLine("Resultado: " + suma);
    }

    // 9. Fraction Difference
    // Resta dos fracciones: numerador1/denominador1 - numerador2/denominador2
    static void FractionDifference()
    {
        Console.Write("Ingresa el numerador de la primera fraccion: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingresa el denominador de la primera fraccion: ");
        int den1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el numerador de la segunda fraccion: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Ingresa el denominador de la segunda fraccion: ");
        int den2 = int.Parse(Console.ReadLine());

        // Para restar fracciones primero igualo los denominadores multiplicando cruzado
        int nuevoNumerador = (num1 * den2) - (num2 * den1);
        int nuevoDenominador = den1 * den2;

        // Simplificamos usando el maximo comun divisor (MCD)
        int mcd = ObtenerMCD(Math.Abs(nuevoNumerador), Math.Abs(nuevoDenominador));

        if (mcd != 0)
        {
            nuevoNumerador = nuevoNumerador / mcd;
            nuevoDenominador = nuevoDenominador / mcd;
        }

        if (nuevoNumerador == 0)
        {
            Console.WriteLine("Resultado: 0");
        }
        else
        {
            Console.WriteLine("Resultado: " + nuevoNumerador + "/" + nuevoDenominador);
        }
    }

    // Metodo de apoyo para el ejercicio 9: calcula el maximo comun divisor
    static int ObtenerMCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // 10. String Length

    
    static void StringLength()
    {
        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine();

        //.Length me dice cuantos caracteres tiene la palabra
        Console.WriteLine("Resultado: " + palabra.Length);
    }

    // 11. Average of Four
    // Calcula el promedio de 4 numeros.
    static void AverageOfFour()
    {
        Console.Write("Ingresa el numero 1: ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el numero 2: ");
        double n2 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el numero 3: ");
        double n3 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el numero 4: ");
        double n4 = double.Parse(Console.ReadLine());

        // El promedio es la suma de los 4 numeros dividida entre 4
        double promedio = (n1 + n2 + n3 + n4) / 4;
        Console.WriteLine("Resultado: " + promedio);
    }

    // 12. Smallest of Five
    // Busca el numero mas pequeño entre 5 numeros.
    static void SmallestOfFive()
    {
        Console.Write("Ingresa el numero 1: ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el numero 2: ");
        double n2 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el numero 3: ");
        double n3 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el numero 4: ");
        double n4 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el numero 5: ");
        double n5 = double.Parse(Console.ReadLine());

        // Empiezo asumiendo que el primer numero es el menor, y lo voy comparando con los demas
        double menor = n1;
        if (n2 < menor) menor = n2;
        if (n3 < menor) menor = n3;
        if (n4 < menor) menor = n4;
        if (n5 < menor) menor = n5;

        Console.WriteLine("Resultado: " + menor);
    }

    // 13. Vowel Counter
    // Cuenta cuantas vocales tiene una palabra.
    static void VowelCounter()
    {
        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        int contador = 0;


        // Recorro cada letra de la palabra y reviso si es una vocal
        for (int i = 0; i < palabra.Length; i++)
        {
            char letra = palabra[i];
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                contador++;
            }
        }

        Console.WriteLine("Resultado: " + contador);
    }

    // 14. Factorial Finder
    // Calcula el factorial de un numero (ejemplo: 5! = 5*4*3*2*1)
    static void FactorialFinder()
    {
        Console.Write("Ingresa un numero: ");
        int numero = int.Parse(Console.ReadLine());

        long factorial = 1;

        // Voy multiplicando el resultado por cada numero desde 1 hasta el numero ingresado
        for (int i = 1; i <= numero; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine("Resultado: " + factorial);
    }

    // 15. InRange Validator
   
    static void InRangeValidator()
    {
        Console.Write("Ingresa un numero: ");
        int numero = int.Parse(Console.ReadLine());


        //Uso && para exigir que se cumplan las dos condiciones(mayor a 10 y menor a 20)
        if (numero >= 10 && numero <= 20)
        {
            Console.WriteLine("Esta en el rango.");
        }
        else
        {
            Console.WriteLine("Fuera del rango.");
        }
    }
}
