namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            
            Console.Write("Original value: ");
            int originalValue = int.Parse(Console.ReadLine());
            
            ModifyByValue(originalValue);
            Console.WriteLine("Value after ModifyByValue: " +  originalValue);

            ModifyByReference(ref originalValue);
            Console.WriteLine("Value afer ModifyByReference: " + originalValue);

        }

        void ModifyByValue(int value) {  value = 30; }

        void ModifyByReference(ref int value) { value = 50; }
    }
}
