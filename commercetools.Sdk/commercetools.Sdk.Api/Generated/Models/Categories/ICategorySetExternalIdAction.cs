using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategorySetExternalIdAction))]
    public partial interface ICategorySetExternalIdAction : ICategoryUpdateAction
    {
        string ExternalId { get; set;}
    }
}
