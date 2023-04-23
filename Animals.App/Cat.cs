namespace Animals.App;

public class Cat : Animal, IVoice
{
    public void Sound()
    {
        Console.WriteLine("Мяу");
    }
}