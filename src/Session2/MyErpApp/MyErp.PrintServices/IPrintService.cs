namespace MyErp.PrintServices;

public interface IPrintService
{
    public void Print<T>(T input);
}
