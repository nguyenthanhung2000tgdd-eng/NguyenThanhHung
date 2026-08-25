internal class Support
{
    private static void Main(string[] args)
    {
        int celsius;
        Console.Write("Nhap nhiet do: ");
        bool ketqua = int.TryParse (Console.ReadLine(), out celsius);
        int kelvin = celsius + 273;
        int fahrenheit = (celsius *18/10)+32
            Console.WriteLine(kelvin);
            Console.WriteLine(fahrenheit);
    }

}
