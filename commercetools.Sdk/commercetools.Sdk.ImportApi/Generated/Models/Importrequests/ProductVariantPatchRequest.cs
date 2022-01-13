using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Productvariants;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Importrequests
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
