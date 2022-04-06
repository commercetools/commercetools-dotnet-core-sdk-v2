using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductVariantImportRequest))]
    public partial interface IProductVariantImportRequest : IImportRequest
    {
        List<IProductVariantImport> Resources { get; set; }
    }
}
