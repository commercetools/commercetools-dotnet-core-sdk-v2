using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Importrequests;
using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


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
