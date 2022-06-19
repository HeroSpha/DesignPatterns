//  implementation

//Singleton pattern

using System.Runtime.CompilerServices;

var fruit = FruitSingleton.Instance;
fruit.WriteAsync();


// Singleton pattern

public class FruitSingleton
{
    private static FruitSingleton instance = new();
    private FruitSingleton(){}

    public static FruitSingleton Instance => instance;

    public void WriteAsync()
    {
        Console.WriteLine("Single Instance");
    }
}

// prototype pattern 

public class FruitProtoType
{
    private static FruitProtoType  instance = new FruitProtoType();
    
    private FruitProtoType() {}

    public static FruitProtoType Clone => (FruitProtoType) instance.MemberwiseClone();
}