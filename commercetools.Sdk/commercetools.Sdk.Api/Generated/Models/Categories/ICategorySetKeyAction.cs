using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategorySetKeyAction))]
    public partial interface ICategorySetKeyAction : ICategoryUpdateAction
    {
        string Key { get; set;}
    }
}
