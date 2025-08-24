namespace Domain.Stores;

public class Store
{
    public long Id { get; set; }
    public required Guid Reference { get; set; }
    public required string Name { get; set; }
}
