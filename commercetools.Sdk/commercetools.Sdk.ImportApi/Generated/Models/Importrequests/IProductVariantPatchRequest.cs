using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductVariantPatchRequest))]
    public partial interface IProductVariantPatchRequest : IImportRequest
    {
        List<IProductVariantPatch> Patches { get; set; }

    }
}
