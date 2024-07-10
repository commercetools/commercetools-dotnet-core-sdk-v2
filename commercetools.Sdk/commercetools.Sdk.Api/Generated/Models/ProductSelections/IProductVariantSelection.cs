using commercetools.Sdk.Api.Models.ProductSelections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelection))]
    [SubTypeDiscriminator("includeAllExcept", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeAllExcept))]
    [SubTypeDiscriminator("includeOnly", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeOnly))]
    public partial interface IProductVariantSelection
    {
        IProductVariantSelectionTypeEnum Type { get; set; }

        static commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeAllExcept IncludeAllExcept(Action<commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeAllExcept> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeAllExcept();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeOnly IncludeOnly(Action<commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeOnly> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeOnly();
            init?.Invoke(t);
            return t;
        }
    }
}
