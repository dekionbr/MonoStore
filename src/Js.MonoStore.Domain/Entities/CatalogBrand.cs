namespace Js.MonoStore.Domain.Entities;

public class CatalogBrand
{
    private CatalogBrand(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public Guid Id { get; private init; }

    public string Name { get; private init; }

    public static CatalogBrand Create(Guid id, string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException($"CatalogBrand.Name is not null or empty");

        return new CatalogBrand(id, name);

    }
}
