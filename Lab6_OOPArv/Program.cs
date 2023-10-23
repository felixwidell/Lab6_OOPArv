namespace Lab6_OOPArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion Lion = new Lion();
            Lion.MakeSound();
            Lion.PrintInfo();
            Lion.IsFasterThanAverageHuman();
            Lion.AmountOfWeightOnEachLeg();
            Lion.IsItDead();
            Console.WriteLine();

            Goldfish Goldfish = new Goldfish();
            Goldfish.MakeSound();
            Goldfish.PrintInfo();
            Goldfish.IsFasterThanAverageHuman();
            Goldfish.LengthOfMemory();
            Console.WriteLine();

            Eagle Eagle = new Eagle();
            Eagle.MakeSound();
            Eagle.PrintInfo();
            Eagle.IsFasterThanAverageHuman();
            Eagle.IsItFlying();
            Console.WriteLine();

            Shubunkin Shubunkin = new Shubunkin();
            Shubunkin.PrintInfo();
            Console.WriteLine();
            Oranda Oranda = new Oranda();
            Oranda.PrintInfo();
        }
    }
}