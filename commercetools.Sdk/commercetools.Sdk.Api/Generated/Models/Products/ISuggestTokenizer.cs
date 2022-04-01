using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Products.SuggestTokenizer))]
    [SubTypeDiscriminator("custom", typeof(commercetools.Sdk.Api.Models.Products.CustomTokenizer))]
    [SubTypeDiscriminator("whitespace", typeof(commercetools.Sdk.Api.Models.Products.WhitespaceTokenizer))]
    public partial interface ISuggestTokenizer
    {
        string Type { get; set; }
    }
}
