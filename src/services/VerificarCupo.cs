
class CuposRestaurantes
{
    public static void VerificarCupo(string nombre, int cantidad, string eleccion, int horario)
    {
        int contador = 0;
        int cupoMaximo = 0;

        // Cada cupo segun restaurante
        if (eleccion == "EMBER" || eleccion == "LARIMAR")
            cupoMaximo = 3;
        else if (eleccion == "GRAPPA")
            cupoMaximo = 2;
        else if (eleccion == "ZAO")
            cupoMaximo = 4;

        // Contar todas las reservas existentes
        for(int i=0; i<Reservacion.Horario_Asistir.Count; i++)
        {
            // Verificar si hay disponibilidad
           if (Reservacion.Horario_Asistir[i] == horario && Reservacion.Eleccion_Restaurante[i] == eleccion)
           {
            contador++;
           }      
        }

        if(contador >= cupoMaximo)
        {
            Console.WriteLine("Este horario se encuentra lleno, elige otro de la lista.");
        }
        else
        {
            Reservacion.NombreCompleto.Add(nombre);
            Reservacion.Cantidad_Personas.Add(cantidad);
            Reservacion.Eleccion_Restaurante.Add(eleccion);
            Reservacion.Horario_Asistir.Add(horario);

            Console.WriteLine("Reserva guardada exitosamente.");
        }
    }
}