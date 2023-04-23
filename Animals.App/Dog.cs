namespace Animals.App;

public class Dog : Animal, IVoice
{
    public void Sound()
    {
        Console.WriteLine("Гав");
    }
}