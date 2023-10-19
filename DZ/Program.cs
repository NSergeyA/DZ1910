using System;

class BankAccount
{
    private static int accountCounter = 1000;

    public int AccountNumber;
    public double Balance;
    public string AccountType;

    // Конструктор класса
    public BankAccount(string accountType)
    {
        AccountNumber = GenerateAccountNumber();
        Balance = 0;
        AccountType = accountType;
    }


    private int GenerateAccountNumber()
    {
        return accountCounter++;
    }


    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Депозит на {amount} успешно выполнен.\nНовый баланс: {Balance}");
        }
        else
        {
            Console.WriteLine("Сумма депозита должна быть больше нуля.");
        }
    }

   
    public void Withdraw(double amount)
    {
        if (amount > 0 && Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Списание {amount} успешно выполнено.\nНовый баланс: {Balance}");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Сумма для списания должна быть больше нуля.");
        }
        else
        {
            Console.WriteLine("Недостаточно средств на счете.");
        }
    }

 
    public void PrintAccountInfo()
    {
        Console.WriteLine($"Номер счета: {AccountNumber}");
        Console.WriteLine($"Баланс: {Balance}");
        Console.WriteLine($"Тип счета: {AccountType}");
    }
}

public class Building
{
    private static int lastBuildingNumber = 0; // поле для хранения последнего использованного номера здания

    private int buildingNumber; // Уникальный номер здания
    private int height; // Высота здания в метрах
    private int floors; // Количество этажей
    private int apartments; // Количество квартир
    private int entrances; // Количество подъездов

    // Конструктор класса
    public Building(int height, int floors, int apartments, int entrances)
    {
        // Генерируем уникальный номер здания и увеличиваем статическое поле
        buildingNumber = ++lastBuildingNumber;
        this.height = height;
        this.floors = floors;
        this.apartments = apartments;
        this.entrances = entrances;
    }

    // Метод для получения значения уникального номера здания
    public int GetBuildingNumber()
    {
        return buildingNumber;
    }

    // Методы для вычисления характеристик
    public int CalculateHeightPerFloor()
    {
        return height / floors;
    }

    public int CalculateApartmentsPerEntrance()
    {
        return apartments / entrances;
    }

    public int CalculateApartmentsPerFloor()
    {
        return apartments / floors;
    }

    // Метод для вывода информации о здании
    public void PrintBuildingInfo()
    {
        Console.WriteLine("Уникальный номер здания: " + buildingNumber);
        Console.WriteLine("Высота здания: " + height + " метров");
        Console.WriteLine("Этажность: " + floors + " этажей");
        Console.WriteLine("Количество квартир: " + apartments);
        Console.WriteLine("Количество подъездов: " + entrances);
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Упражение 7.1 + 7.2 + 7.3");
        
        BankAccount account = new BankAccount("Сберегательный счет");

   
        account.Deposit(1243242);


        account.Withdraw(14324);

 
        account.PrintAccountInfo();
  
        Console.WriteLine("Для продолжения нажмите любую кнопку");
        Console.ReadKey();
        Console.WriteLine("//////////////////");
        Console.WriteLine("Домашнее задание 7.1");

        Building building1 = new Building(100, 20, 80, 4);
        Building building2 = new Building(75, 15, 75, 5);

        building1.PrintBuildingInfo();
        Console.WriteLine("Высота этажа: " + building1.CalculateHeightPerFloor() + " метра");
        Console.WriteLine("Квартир в подъезде: " + building1.CalculateApartmentsPerEntrance());
        Console.WriteLine("Квартир на этаже: " + building1.CalculateApartmentsPerFloor());
        Console.WriteLine("/////////////////////");

        building2.PrintBuildingInfo();
        Console.WriteLine("Высота этажа: " + building2.CalculateHeightPerFloor() + " метра");
        Console.WriteLine("Квартир в подъезде: " + building2.CalculateApartmentsPerEntrance());
        Console.WriteLine("Квартир на этаже: " + building2.CalculateApartmentsPerFloor());
        Console.ReadKey();
    }
}