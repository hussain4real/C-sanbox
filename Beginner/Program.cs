namespace Beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7];

            numbers[0] = 4;
            numbers[1] = 7;
            numbers[2] = 10;

            short justByte = 245;
            Console.WriteLine(justByte);
            Console.ReadLine();

            justByte += 1;
            Console.WriteLine(justByte);
            Console.ReadLine();

            Console.WriteLine($"this is the lenght of numbers array: {numbers.Length}");
        }
    }
}
