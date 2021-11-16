using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Products
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Products.SearchKeyword))]
    public partial interface ISearchKeyword
    {
        string Text { get; set; }

        ISuggestTokenizer SuggestTokenizer { get; set; }
    }
}
