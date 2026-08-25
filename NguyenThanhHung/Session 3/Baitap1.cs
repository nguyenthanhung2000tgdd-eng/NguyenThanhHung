internal class EX01
{
	static void ex01()
	{
		Console.Write("Nhap vao do Celsius: ");
		float celsius = float.Parse(Console.ReadLine());
		float kelvin = celsius + 273;
		float fahrenheit = celsius + 18 / 10 + 32;
        Console.WriteLine($"{celsius} C {kelvin} k {fahrenheit} F");
	}
	public static void Main( string[] args )
	{
		 ex01();
	}
}
