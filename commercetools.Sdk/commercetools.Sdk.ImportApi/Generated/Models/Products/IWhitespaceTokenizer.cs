using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Products
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Products.WhitespaceTokenizer))]
    public partial interface IWhitespaceTokenizer : ISuggestTokenizer
    {
    }
}
