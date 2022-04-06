using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Products
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.ImportApi.Models.Products.SuggestTokenizer))]
    [SubTypeDiscriminator("custom", typeof(commercetools.Sdk.ImportApi.Models.Products.CustomTokenizer))]
    [SubTypeDiscriminator("whitespace", typeof(commercetools.Sdk.ImportApi.Models.Products.WhitespaceTokenizer))]
    public partial interface ISuggestTokenizer
    {
        string Type { get; set; }
    }
}
