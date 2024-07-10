using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Products.FacetResult))]
    [SubTypeDiscriminator("filter", typeof(commercetools.Sdk.Api.Models.Products.FilteredFacetResult))]
    [SubTypeDiscriminator("range", typeof(commercetools.Sdk.Api.Models.Products.RangeFacetResult))]
    [SubTypeDiscriminator("terms", typeof(commercetools.Sdk.Api.Models.Products.TermFacetResult))]
    public partial interface IFacetResult
    {
        IFacetTypes Type { get; set; }

        static commercetools.Sdk.Api.Models.Products.FilteredFacetResult Filter(Action<commercetools.Sdk.Api.Models.Products.FilteredFacetResult> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.FilteredFacetResult();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.RangeFacetResult Range(Action<commercetools.Sdk.Api.Models.Products.RangeFacetResult> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.RangeFacetResult();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.TermFacetResult Terms(Action<commercetools.Sdk.Api.Models.Products.TermFacetResult> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.TermFacetResult();
            init?.Invoke(t);
            return t;
        }
    }
}
