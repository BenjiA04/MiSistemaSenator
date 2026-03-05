

class ListadoReservaciones
{
    public static void ImprimirListado(List<string> nombre, List<int> cantidad, List<string> eleccion, List<int> horario)
    {
        Console.WriteLine("\n=========== RESERVACIONES ==========\n");

        if(nombre.Count() == 0){Console.WriteLine("    Sin reservaciones...");}
        
        else{
             for (int i = 0; i < nombre.Count; i++)
             {
              Console.WriteLine($"[{i + 1}] {nombre[i].Trim()}");
              Console.WriteLine($"    Cantidad de Personas: {cantidad[i]}");
              Console.WriteLine($"    Restaurante: {eleccion[i]}");
              Console.WriteLine($"    Horario:  {Restaurante.Horarios[horario[i]]}");
              Console.WriteLine("-------------------------------------");
             }
        }
    }
}