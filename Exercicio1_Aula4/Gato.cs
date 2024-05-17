public class Gato : Animal
{
    public int Idade { get; set; }
    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
    }
}