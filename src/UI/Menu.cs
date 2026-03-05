
    class Menu
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("\n✨ Bienvenido a Complejos Turísticos Senator ✨ ");
            Console.WriteLine("Un lugar donde la diversión, el descanso y el buen sazón se unen para brindarte una experiencia inolvidable.");
            Console.WriteLine("Descubre nuestra selección de restaurantes y servicios diseñados especialmente para ti.");
            Console.WriteLine("¡Elige tu opción y comienza a disfrutar!");

            int Opcion;

            do{
            
            Console.WriteLine("\n=========== MENU ==========");
            Console.WriteLine("1. Realizar Reservación.");
            Console.WriteLine("2. Eliminar Reservación.");
            Console.WriteLine("3. Ver Disponibilidad.");
            Console.WriteLine("4. Imprimir Listado.");
            Console.WriteLine("=============================");

            Console.Write("\nOpcion: ");
            Opcion = int.Parse(Console.ReadLine()!);

            switch (Opcion)
            {
                case 1:
                Console.WriteLine("\n--Realizar Reservacion-- \n");
                Reservaciones.RealizarReservaciones();
                break;

                case 2:
                Console.WriteLine("\n--Eliminar Reservacion--\n");
                Eliminar.EliminarReservaciones(Reservacion.NombreCompleto, Reservacion.Cantidad_Personas, Reservacion.Eleccion_Restaurante, Reservacion.Horario_Asistir);
                break;

                case 3:
                Console.WriteLine("\n--Ver disponibilidad--");
                Disponibilidad.ValidarDisponibilidad();
                break;

                case 4:
                Console.WriteLine("\n--Imprimir Listado--\n");
                ListadoReservaciones.ImprimirListado(Reservacion.NombreCompleto, Reservacion.Cantidad_Personas, Reservacion.Eleccion_Restaurante, Reservacion.Horario_Asistir);
                break;

                default:
                System.Console.WriteLine("Esta no es una opcion disponible");
                break;
            }
                Console.Write("\n¿Quieres volver al menu? ");
                string volverAlmenu = (Console.ReadLine()!);
                Console.WriteLine("");

                if(volverAlmenu == "si"){Opcion = 5;}
                else {Console.WriteLine("¡Gracias por preferirnos!");}

            } while(Opcion != 1 && Opcion != 2 && Opcion != 3 && Opcion != 4);
        }
    }
