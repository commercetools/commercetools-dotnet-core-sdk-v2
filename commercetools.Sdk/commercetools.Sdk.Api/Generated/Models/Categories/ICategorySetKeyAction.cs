using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategorySetKeyAction))]
    public partial interface ICategorySetKeyAction : ICategoryUpdateAction
    {
        string Key { get; set; }

    }
}
