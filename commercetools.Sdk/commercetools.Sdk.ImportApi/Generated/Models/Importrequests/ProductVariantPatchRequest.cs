using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class ProductVariantPatchRequest : IProductVariantPatchRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IProductVariantPatch> Patches { get; set; }
        public IEnumerable<IProductVariantPatch> PatchesEnumerable { set => Patches = value.ToList(); }

        public ProductVariantPatchRequest()
        {
            this.Type = IImportResourceType.FindEnum("product-variant-patch");
        }
    }
}
