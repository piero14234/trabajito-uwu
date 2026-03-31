// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


double num1, num2, resultado = 0;
            string operacion;

            Console.WriteLine(" Calculadora ");

            
            Console.Write("Ingresa el primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            
            Console.Write("¿Que quieres hacer? (+, -, *, /): ");
            operacion = Console.ReadLine();

           
            Console.Write("Ingresa el segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

         
            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    return;
            }

            Console.WriteLine($"\nEl resultado de {num1} {operacion} {num2} es: {resultado}");
            
            Console.WriteLine("\nPresiona cualquier tecla para salir");
            Console.ReadKey();
        