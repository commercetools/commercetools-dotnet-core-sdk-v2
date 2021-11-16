using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.Suggestion))]
    public partial interface ISuggestion
    {
        string Text { get; set; }
    }
}
