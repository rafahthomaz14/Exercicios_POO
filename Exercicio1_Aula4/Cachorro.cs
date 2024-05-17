public class Cachorro : Animal
{
    public bool Vacinacao { get; set; }
    public override void EmitirSom()
    {
        Console.WriteLine("AU AU!");
    }
}