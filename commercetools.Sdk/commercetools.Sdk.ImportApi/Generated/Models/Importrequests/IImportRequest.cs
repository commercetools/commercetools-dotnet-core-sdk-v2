using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ImportRequest))]
    [SubTypeDiscriminator("category", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.CategoryImportRequest))]
    [SubTypeDiscriminator("customer", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.CustomerImportRequest))]
    [SubTypeDiscriminator("inventory", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.InventoryImportRequest))]
    [SubTypeDiscriminator("order", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.OrderImportRequest))]
    [SubTypeDiscriminator("order-patch", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.OrderPatchImportRequest))]
    [SubTypeDiscriminator("price", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.PriceImportRequest))]
    [SubTypeDiscriminator("product", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductImportRequest))]
    [SubTypeDiscriminator("product-draft", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductDraftImportRequest))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductTypeImportRequest))]
    [SubTypeDiscriminator("product-variant", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductVariantImportRequest))]
    [SubTypeDiscriminator("product-variant-patch", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductVariantPatchRequest))]
    public partial interface IImportRequest
    {
        IImportResourceType Type { get; set; }
    }
}
