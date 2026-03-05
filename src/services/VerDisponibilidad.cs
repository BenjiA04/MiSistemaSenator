

class Disponibilidad
{
    public static void ValidarDisponibilidad()
{
    // Recorre cada restaurante
    foreach(string restaurante in Restaurante.Nombres)
    {
        int cupoMaximo = 0;
        
        // Cada cupo segun restaurante
        if (restaurante == "EMBER" || restaurante == "LARIMAR")
            cupoMaximo = 3;
        else if (restaurante == "GRAPPA")
            cupoMaximo = 2;
        else if (restaurante == "ZAO")
            cupoMaximo = 4;

        Console.WriteLine("\n--------------------------");
        // Recorre cada horario disponible
        for(int h = 0; h < Restaurante.Horarios.Count; h++)
        {
            int contador = 0;

            // Recorre todas las reservas guardadas
            for(int r = 0; r < Reservacion.Eleccion_Restaurante.Count; r++)
            {
                if(Reservacion.Eleccion_Restaurante[r] == restaurante && Reservacion.Horario_Asistir[r] == h)
                {
                    contador++;
                }
            }

            int disponibles = cupoMaximo - contador;

            Console.WriteLine($"{restaurante} - {Restaurante.Horarios[h]}: {disponibles} cupos disponibles");
        }
        Console.WriteLine("--------------------------");
    }
}
}
