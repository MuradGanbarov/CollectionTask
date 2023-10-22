namespace Task1Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,string> proglashdirma_dilleri = new SortedList<int,string>();
            proglashdirma_dilleri.TryAdd(1991,"Python");
            proglashdirma_dilleri.TryAdd(1972, "C");
            proglashdirma_dilleri.TryAdd(1970, "Pascal");
            proglashdirma_dilleri.TryAdd(1989, "C++");
            proglashdirma_dilleri.TryAdd(1998, "C#");
            proglashdirma_dilleri.TryAdd(1995, "Ruby");
            
            foreach(var c in proglashdirma_dilleri)
            {
                Console.WriteLine(c);
            }

        }
    }
}