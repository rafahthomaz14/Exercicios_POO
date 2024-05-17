public class Canario : Animal
{
    public bool Cantando { get; set; }
    public override void EmitirSom()
    {
        Console.WriteLine("piu piu");
    }
}
