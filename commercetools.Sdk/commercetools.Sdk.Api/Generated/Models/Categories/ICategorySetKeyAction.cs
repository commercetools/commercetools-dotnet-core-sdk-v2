using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategorySetKeyAction))]
    public partial interface ICategorySetKeyAction : ICategoryUpdateAction
    {
        string Key { get; set; }
    }
}
