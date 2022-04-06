using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Products.SearchKeyword))]
    public partial interface ISearchKeyword
    {
        string Text { get; set; }

        ISuggestTokenizer SuggestTokenizer { get; set; }
    }
}
