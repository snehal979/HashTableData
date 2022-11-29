namespace HashTableData
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hashtable");
            HashingStructure<int, string> list = new HashingStructure<int, string>(10);
            list.Add(1, "Paranoids");
            list.Add(2, "are");
            list.Add(3, " not");
            list.Add(4, "paranoid");
            list.Add(5, "because");
            list.Add(6, "they");
            list.Add(7, "are");
            list.Add(8, "paranoid");
            list.Add(9, "but");
            list.Add(10, "because");
            list.Add(11, "they");
            list.Add(12, "keep");
            list.Add(13, "putting");
            list.Add(14, "themselves");
            list.Add(15, "deliberately");
            list.Add(16, "into ");
            list.Add(17, "paranoid");
            list.Add(18, "avoidable");
            list.Add(19, "situations");

            for(int i =1; i < 20; i++)
            {
                string hash5 = list.Get(i);
                Console.WriteLine("{0}th index value {1} ",i,hash5);

            }




            Console.WriteLine(list.GetHashCode()); 



        }
    }
}