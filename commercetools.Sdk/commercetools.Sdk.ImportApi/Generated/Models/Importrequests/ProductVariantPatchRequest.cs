using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    public partial class ProductVariantPatchRequest : IProductVariantPatchRequest
    {
        public IImportResourceType Type { get; set; }

        public List<IProductVariantPatch> Patches { get; set; }
        public ProductVariantPatchRequest()
        {
            this.Type = IImportResourceType.FindEnum("product-variant-patch");
        }
    }
}
