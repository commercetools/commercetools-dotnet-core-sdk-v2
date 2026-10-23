using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategoryAddStoreWithDescendantsAction))]
    public partial interface ICategoryAddStoreWithDescendantsAction : ICategoryUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }

    }
}
