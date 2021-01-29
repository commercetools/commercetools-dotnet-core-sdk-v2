using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Productvariants;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.ProductVariantPatch))]
    public partial interface IProductVariantPatch 
    {
        IProductVariantKeyReference ProductVariant { get; set;}
        
        IAttributes Attributes { get; set;}
    }
}
