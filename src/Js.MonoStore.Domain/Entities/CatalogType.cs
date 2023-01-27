namespace Js.MonoStore.Domain.Entities;

public class CatalogType
{
    private CatalogType(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public Guid Id { get; private init; }

    public string Name { get; private init; }

    public static CatalogType Create(Guid id, string name)
    {

        if(string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException($"CatalogType.Name is not null or empty");

        return new CatalogType(id, name);
        
    }
}
