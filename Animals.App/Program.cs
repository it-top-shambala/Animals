using Animals.App;

var exit = false;
do
{
    Console.WriteLine("Виды животных");
    Console.WriteLine("1. Рыбы");
    Console.WriteLine("2. Пауки");
    Console.WriteLine("3. Собаки");
    Console.WriteLine("4. Кошки");
    Console.WriteLine("0. Выход");
    var input = Console.ReadLine();
    
    Animal animal = null;

    switch (input)
    {
        case "1":
            animal = new Fish();
            break;
        case "2":
            animal = new Spider();
            break;
        case "3":
            animal = new Dog();
            break;
        case "4":
            animal = new Cat();
            break;
        case "0":
            exit = true;
            break;
        default:
            Console.WriteLine("Ошибка ввода! Повторите ввод");
            break;
    }
    
    PrintVoice(animal);

} while (!exit);

void PrintVoice(Animal animal)
{
    if (animal is IVoice)
    {
        ((IVoice)animal).Sound();
    }
    else
    {
        Console.WriteLine("Животное не умеет издавать звуки");
    }
}