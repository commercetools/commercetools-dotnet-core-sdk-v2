using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.WhitespaceTokenizer))]
    public partial interface IWhitespaceTokenizer : ISuggestTokenizer
    {
    }
}
