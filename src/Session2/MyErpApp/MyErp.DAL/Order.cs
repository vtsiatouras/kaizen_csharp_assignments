namespace MyErp.DAL;

public class Order
{
    public required string Id { get; set; }
    public required Customer Customer { get; set; }
}
