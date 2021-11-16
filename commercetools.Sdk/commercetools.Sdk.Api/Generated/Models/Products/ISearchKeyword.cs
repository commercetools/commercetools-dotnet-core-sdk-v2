using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.SearchKeyword))]
    public partial interface ISearchKeyword 
    {
        string Text { get; set;}
        
        ISuggestTokenizer SuggestTokenizer { get; set;}
    }
}
