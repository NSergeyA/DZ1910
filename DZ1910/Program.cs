using System;

// Абстрактный класс, представляющий детский садик
abstract class Kindergarten
{
    // Свойство на чтение-запись для названия детского сада
    public string Name { get; set; }

    // Конструктор класса
    public Kindergarten(string name)
    {
        Name = name;
    }

    // Абстрактный метод, который должен быть реализован в наследниках
    public abstract void PrintInfo();

    // Виртуальный метод для показа сообщения
    public virtual void WelcomeMessage()
    {
        Console.WriteLine("Добро пожаловать в детский сад " + Name + "!");
    }
}

// Наследник класса Kindergarten
class Nursery : Kindergarten
{
    // Свойство на чтение для возраста детей
    public int Age { get; }

    // Конструктор класса
    public Nursery(string name, int age) : base(name)
    {
        Age = age;
    }

    // Метод для вывода информации о детском саде и возрасте детей
    public override void PrintInfo()
    {
        Console.WriteLine($"Дети возрастом до {Age} лет посещают детский сад {Name}.");
    }

    // Переопределение виртуального метода для показа специального сообщения
    public override void WelcomeMessage()
    {
        Console.WriteLine($"Добро пожаловать в детский сад {Name}! Здесь играют и учатся дети возрастом до {Age} лет.");
    }
}

// Наследник класса Kindergarten
class Preschool : Kindergarten
{
    // Свойство на чтение для количества классов
    public int ClassCount { get; }

    // Конструктор класса
    public Preschool(string name, int classCount) : base(name)
    {
        ClassCount = classCount;
    }

    // Метод для вывода информации о детском саде и количестве классов
    public override void PrintInfo()
    {
        Console.WriteLine($"Детский сад {Name} имеет {ClassCount} класса(-ов).");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов 
        Nursery nursery = new Nursery("Сказка", 5);
        Preschool preschool = new Preschool("Радуга", 3);

        // Вызов объектов
        nursery.WelcomeMessage();
        nursery.PrintInfo();

        Console.WriteLine();

        preschool.WelcomeMessage();
        preschool.PrintInfo();
    }
}
