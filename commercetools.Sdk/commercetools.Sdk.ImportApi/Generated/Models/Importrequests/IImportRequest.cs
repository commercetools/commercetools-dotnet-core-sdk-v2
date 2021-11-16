using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.ImportApi.Models.Importrequests.ImportRequest))]
    [SubTypeDiscriminator("category", typeof(commercetools.ImportApi.Models.Importrequests.CategoryImportRequest))]
    [SubTypeDiscriminator("customer", typeof(commercetools.ImportApi.Models.Importrequests.CustomerImportRequest))]
    [SubTypeDiscriminator("inventory", typeof(commercetools.ImportApi.Models.Importrequests.InventoryImportRequest))]
    [SubTypeDiscriminator("order", typeof(commercetools.ImportApi.Models.Importrequests.OrderImportRequest))]
    [SubTypeDiscriminator("order-patch", typeof(commercetools.ImportApi.Models.Importrequests.OrderPatchImportRequest))]
    [SubTypeDiscriminator("price", typeof(commercetools.ImportApi.Models.Importrequests.PriceImportRequest))]
    [SubTypeDiscriminator("product", typeof(commercetools.ImportApi.Models.Importrequests.ProductImportRequest))]
    [SubTypeDiscriminator("product-draft", typeof(commercetools.ImportApi.Models.Importrequests.ProductDraftImportRequest))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.ImportApi.Models.Importrequests.ProductTypeImportRequest))]
    [SubTypeDiscriminator("product-variant", typeof(commercetools.ImportApi.Models.Importrequests.ProductVariantImportRequest))]
    [SubTypeDiscriminator("product-variant-patch", typeof(commercetools.ImportApi.Models.Importrequests.ProductVariantPatchRequest))]
    public partial interface IImportRequest 
    {
        IImportResourceType Type { get; set;}
    }
}
