using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
