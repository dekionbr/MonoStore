using Js.MonoStore.Domain.Primitives;

namespace Js.MonoStore.Domain.Entities;

public class CatalogItem : Entity
{

    protected CatalogItem(Guid id, string name, string description, decimal price, string pictureFileName, string pictureUri, int catalogTypeId, CatalogType catalogType, int catalogBrandId, CatalogBrand catalogBrand, int availableStock, int restockThreshold, int maxStockThreshold)
        : base(id)
    {
        Name = name;
        Description = description;
        Price = price;
        PictureFileName = pictureFileName;
        PictureUri = pictureUri;
        CatalogTypeId = catalogTypeId;
        CatalogType = catalogType;
        CatalogBrandId = catalogBrandId;
        CatalogBrand = catalogBrand;
        AvailableStock = availableStock;
        RestockThreshold = restockThreshold;
        MaxStockThreshold = maxStockThreshold;
    }

    public string Name { get; private init; }

    public string Description { get; private init; }

    public decimal Price { get; private init; }

    public string PictureFileName { get; private init; }

    public string PictureUri { get; private init; }

    public int CatalogTypeId { get; private init; }

    public CatalogType CatalogType { get; private init; }

    public int CatalogBrandId { get; private init; }

    public CatalogBrand CatalogBrand { get; private init; }

    // Quantity in stock
    public int AvailableStock { get; private init; }

    // Available stock at which we should reorder
    public int RestockThreshold { get; private init; }


    // Maximum number of units that can be in-stock at any time (due to physicial/logistical constraints in warehouses)
    public int MaxStockThreshold { get; init; }



}
