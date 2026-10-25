using Gym.Models;

public static class AppMenu
{
    public static void DisplayMenu(List<Activity> activities)
    {
        var option = -1;

        do
        {
            ShowMenu();
            option = ChooseOption();

            switch(option)
            {
                case 1:
                    Console.WriteLine();
                    ShowActivities(activities);
                    break;
                case 2:
                    Console.WriteLine();
                    SearchActivitiesByName(activities);
                    break;
                case 3:
                    Console.WriteLine();
                    SearchActivitiesByMaxDuration(activities);
                    break;
                case 4:
                    Console.WriteLine();
                    SearchActivitiesByType(activities);
                    break;
                case 0:
                    Console.WriteLine("\nSaliendo del programa...");
                    break;
                default:
                    Console.WriteLine("\nOpción no válida. Introduzca un número del 0 al 4.");
                    break;
            }

        } while (option != 0);
    }

    public static void ShowMenu()
    {
        Console.WriteLine("\n=== GIMNASIO ===");
        Console.WriteLine("1. Ver actividades");
        Console.WriteLine("2. Buscar actividad");
        Console.WriteLine("3. Ver actividades por duración máxima");
        Console.WriteLine("4. Ver actividades por tipo");
        Console.WriteLine("0. Salir");
    }

    public static int ChooseOption()
    {
        Console.Write("\nElija una opción: ");
        var input = Console.ReadLine();

        /*
        if (input is null)
        {
            return 0;
        }
        */

        if (!int.TryParse(input, out var decision))
        {
            return -1;
        }

        return decision;
    }

    public static void ShowActivities(List<Activity> activities)
    {
        foreach (var activity in activities)
        {
            activity.ShowDescription();
        }
    }

    public static void SearchActivitiesByName(List<Activity> activities)
    {
        Console.Write("\nIntroduzca el nombre de la actividad a buscar: ");
        var input = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("\nOpción incorrecta");
            return;
        }

        input = input.Trim().ToLower();
        var found = false;

        Console.WriteLine();
        foreach (var activity in activities)
        {
            if (activity.Name.Trim().ToLower().Contains(input))
            {
                activity.ShowDescription();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nNo se ha encontrado ninguna actividad con ese nombre.");
        }
    }

    public static void SearchActivitiesByMaxDuration(List<Activity> activities)
    {
        Console.Write("\nIntroduzca la duración máxima a buscar: ");
        var input = Console.ReadLine();

        if (!int.TryParse(input, out var decision))
        {
            Console.WriteLine("\nOpción incorrecta");
            return;
        }

        if (decision <= 0)
        {
            Console.WriteLine("\n La duración no puede ser menor o igual a 0");
            return;
        }

        var found = false;

        Console.WriteLine();
        foreach (var activity in activities)
        {
            if (activity.Duration <= decision)
            {
                activity.ShowDescription();            
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nNo se ha encontrado ninguna actividad con esa duración máxima.");
        }
    }

    public static void SearchActivitiesByType(List<Activity> activities)
    {
        Console.Write("\nIntroduzca el tipo de actividad: ");
        var input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("\nOpción incorrecta.");
            return;
        }

        input = input.Trim().ToLower();
        var found = false;

        Console.WriteLine();
        foreach (var activity in activities)
        {
            if (activity.GetType().Name.Equals(input, StringComparison.OrdinalIgnoreCase))
            {
                activity.ShowDescription();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nNo se ha encontrado ninguna actividad de ese tipo.");
        }
    }
}