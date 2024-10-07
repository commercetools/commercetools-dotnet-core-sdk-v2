using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategorySetExternalIdAction))]
    public partial interface ICategorySetExternalIdAction : ICategoryUpdateAction
    {
        string ExternalId { get; set; }

    }
}
