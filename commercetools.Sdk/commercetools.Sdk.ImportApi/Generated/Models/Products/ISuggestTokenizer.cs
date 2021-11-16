using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Products
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.ImportApi.Models.Products.SuggestTokenizer))]
    [SubTypeDiscriminator("custom", typeof(commercetools.ImportApi.Models.Products.CustomTokenizer))]
    [SubTypeDiscriminator("whitespace", typeof(commercetools.ImportApi.Models.Products.WhitespaceTokenizer))]
    public partial interface ISuggestTokenizer
    {
        string Type { get; set; }
    }
}
