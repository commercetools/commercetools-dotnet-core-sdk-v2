using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Products.SuggestTokenizer))]
    [SubTypeDiscriminator("custom", typeof(commercetools.Api.Models.Products.CustomTokenizer))]
    [SubTypeDiscriminator("whitespace", typeof(commercetools.Api.Models.Products.WhitespaceTokenizer))]
    public partial interface ISuggestTokenizer 
    {
        string Type { get; set;}
    }
}
