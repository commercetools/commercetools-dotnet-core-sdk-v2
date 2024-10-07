using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.Suggestion))]
    public partial interface ISuggestion
    {
        string Text { get; set; }

    }
}
