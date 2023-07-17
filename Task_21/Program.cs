{
        Console.WriteLine("Введите координаты первой точки:");
        Console.Write("X1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Y1: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Z1: ");
        double z1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты второй точки:");
        Console.Write("X2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Y2: ");
        double y2 = double.Parse(Console.ReadLine());
        Console.Write("Z2: ");
        double z2 = double.Parse(Console.ReadLine());

        double distance = CalculateDistance(x1, y1, z1, x2, y2, z2);
        Console.WriteLine($"Расстояние между точками: {distance:F2}");
    }
	
static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        double dz = z2 - z1;

        double distance = Math.Sqrt(dx * dx + dy * dy + dz * dz);
        return distance;
    }
    