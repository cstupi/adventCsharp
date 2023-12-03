internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        GetInput("./input1.txt");
    
    
    }
    public static string GetInput(string filename) {
    try {
        StreamReader sr = new StreamReader(filename);
        while(sr.)
        return "success";
    } catch(Exception e) {
        Console.WriteLine(e);
    }
    return "";
}
}