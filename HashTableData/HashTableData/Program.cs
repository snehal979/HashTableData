namespace HashTableData
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hashtable");
            HashingStructure<int, string> list = new HashingStructure<int, string>(10);
            list.Add(1, "to");
            list.Add(2, "be");
            list.Add(3, "or");
            list.Add(4, "not");
            list.Add(5, "to");
            list.Add(6, "be");
            




        }
    }
}