//main
List<Car> cars = new List<Car>();

Console.WriteLine("Garage Management System :");
for (; true;)
{
    #region messages
    Console.WriteLine("\nMAIN MENU");
    Console.WriteLine("\n1. Add a car");
    Console.WriteLine("2. View all cars");
    Console.WriteLine("3. Exit");
    Console.WriteLine("Enter your choice..!");
    #endregion
    int choice = int.Parse(Console.ReadLine());
    if (choice == 1)
    {
        Car newCar = new Car();

        Console.WriteLine("Add a car selected");
        Console.WriteLine("Enter the car brand");
        string cb = Console.ReadLine();
        Console.WriteLine("Enter the car model");
        string cm = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(cb) == false && string.IsNullOrWhiteSpace(cm) == false)
        {
            newCar.CarBrand = cb;
            newCar.CarModel = cm;
            Console.WriteLine($"Car added succssesfully...\n Brand: {newCar.CarBrand}\n Model: {newCar.CarModel}");
            cars.Add(newCar);
        }
        else
        {
            Console.WriteLine("invalid...!");
        }

        continue;
    }
    else if (choice == 2)
    {
        Console.WriteLine("View all cars selected");
        if (cars.Count == 0)
        {
            Console.WriteLine("no car brand or models added");
            continue;
        }
        else
        {
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine(i + 1);
                Console.WriteLine($"Brand: {cars[i].CarBrand}\nModel: {cars[i].CarModel}");
                Console.WriteLine("-------------------------------");

            }
        }
    }
    else if (choice == 3)
    {
        Console.WriteLine("Goodbye!");
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice!");
    }
}





//classes

class Car
{
    private string carBrand;
    private string carModel;

    public string CarBrand
    {
        get { return carBrand; }
        set { carBrand = value; }
    }
    public string CarModel
    {
        get { return carModel; }
        set { carModel = value; }
    }
}