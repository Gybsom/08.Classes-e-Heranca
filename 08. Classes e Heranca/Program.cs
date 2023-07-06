internal class Program
{
    private static void Main(string[] args)
    {
        Cachorro caramelo = new Cachorro("vira-lata","latido");
        caramelo.Apresentacao();
        caramelo.Comportamento();

        Gato frajola = new Gato("siamês","miado");
        frajola.Apresentacao();
        frajola.Comportamento();

        Console.ReadKey();
    }
}

public class Animal
{
    private string raca;
    private string som;

    public Animal(string raca, string som)
    {
        Raca = raca;
        Som = som;
    }

    public string Raca 
    { 
        get { return raca; } 
        set { raca = value; } 
    }

    public string Som
    {
        get { return som; }
        set { som = value; }
    }

    public void Apresentacao()
    {
        Console.WriteLine($"Eu sou um {Raca} e o meu som é o {Som}");
    }

    public virtual void Comportamento() { }


}

public class Cachorro : Animal
{
    public Cachorro(string raca, string som) : base(raca, som) { }

    public override void Comportamento()
    {
        Console.WriteLine("O doguinho gosta de correr pelo quintal");
    }
}

public class Gato : Animal
{
    public Gato(string raca, string som) : base(raca, som) { }

    public override void Comportamento()
    {
        Console.WriteLine("O gatinho gosta de subir nos móveis");
    }
}