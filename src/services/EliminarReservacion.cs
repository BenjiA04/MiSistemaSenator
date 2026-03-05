
class Eliminar
{
    public static void EliminarReservaciones(List<string> nombre, List<int> cantidad, List<string> eleccion, List<int> horario)
    {
        Console.Write("Ingrese el nombre de la reservacion que quiere eliminar: ");
        string Reservacion_Eliminar = Console.ReadLine()!;

        bool ReservacionEncontrada = nombre.Contains(Reservacion_Eliminar);

        for(int i=0; i<nombre.Count; i++)
        {
            if (nombre[i].Equals(Reservacion_Eliminar))
            {
                nombre.RemoveAt(i);
                cantidad.RemoveAt(i);
                eleccion.RemoveAt(i);
                horario.RemoveAt(i);

                Console.WriteLine("Reservacion Eliminada.");
            }
        }
        
        if (!ReservacionEncontrada) { Console.WriteLine($"Reservacion a nombre de {Reservacion_Eliminar} no existe..."); }
    }
}