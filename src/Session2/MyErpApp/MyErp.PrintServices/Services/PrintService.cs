using Newtonsoft.Json;

namespace MyErp.PrintServices.Services;

public class PrintService : IPrintService
{
    public void Print<T>(T input)
    {
        Console.WriteLine(JsonConvert.SerializeObject(input));
    }
}
