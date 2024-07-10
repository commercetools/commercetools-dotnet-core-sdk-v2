using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class ProductVariantPatch : IProductVariantPatch
    {
        public IProductVariantKeyReference ProductVariant { get; set; }

        public IAttributes Attributes { get; set; }

        public bool? Staged { get; set; }

        public IProductKeyReference Product { get; set; }
    }
}
