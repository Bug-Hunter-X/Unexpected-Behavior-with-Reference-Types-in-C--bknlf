public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public static void Main(string[] args)
    {
        // Correct usage: create a copy to avoid modifying the original
        ExampleClass obj1 = new ExampleClass(10);
        ExampleClass obj2 = new ExampleClass(obj1.MyProperty); // Create a copy
        obj2.MyProperty = 20;

        Console.WriteLine(obj1.MyProperty); // Output: 10 (expected)
        Console.WriteLine(obj2.MyProperty); // Output: 20 (expected)
    }
}
