namespace EverythingService
{
    internal class Program
    {
        const int MAX_RESULTS = 20;
        static void Main(string[] args)
        {
            Console.Write("Enter your search query:");
            var qry = Console.ReadLine();

            var results = Everything.Search(qry);
            var resultCount = 0;
            foreach (Everything.Result result in results.Where(r => r.Type == Everything.ItemType.Folder))
            {
                resultCount++;
                if (resultCount > MAX_RESULTS)
                    break;

                Console.WriteLine($"{resultCount:D2}. {result}");
            }
        }
    }
}
