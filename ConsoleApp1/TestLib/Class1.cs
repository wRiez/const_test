namespace TestLib
{
    public class Class1
    {
        string name;
        public Class1(string name)
        {
            this.name = name;
        }
        public void Print() => Console.WriteLine($"Name: {name}");
    }
}
