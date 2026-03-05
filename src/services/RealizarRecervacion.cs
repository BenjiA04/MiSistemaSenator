using System.Collections.Generic;

    class Reservaciones
    {
        public static void RealizarReservaciones()
        {   
            int contador = 1;

            // Capturamos los valores en variables temporales
            Console.Write("- Nombre completo: ");
            string NombreCompleto = Console.ReadLine()!;

            Console.Write("- Cantidad de personas: ");
            int Cantidad_Personas = int.Parse(Console.ReadLine()!);


            Console.WriteLine("\n Nuestros restaurantes: ");
            foreach(string i in Restaurante.Nombres){
                Console.WriteLine($"- {i} ");
            }
            Console.Write("\n- Restaurante a cual asistira: ");
            string Eleccion_Restaurante = Console.ReadLine()!;
            // Para que la primera letra sea mayuscula
            Eleccion_Restaurante = Eleccion_Restaurante.ToUpper();

            while(!Restaurante.Nombres.Contains(Eleccion_Restaurante)){
                Console.WriteLine("Eleccion invalida");
                
                Console.Write("\n- Restaurante a cual asistira: ");
                Eleccion_Restaurante = Console.ReadLine()!;
                Eleccion_Restaurante = Eleccion_Restaurante.ToUpper();
            }

            Console.WriteLine("\n Horario Disponibles: ");
            foreach(string i in Restaurante.Horarios){
                Console.WriteLine($" Turno {contador++}: {i} ");
            }

            Console.Write("\n- Horario a elegir: ");
            int Horario_Asistir = int.Parse(Console.ReadLine()!)-1;

            // Lo enviamos a la funcion
            CuposRestaurantes.VerificarCupo(NombreCompleto, Cantidad_Personas, Eleccion_Restaurante, Horario_Asistir);
        }
    }