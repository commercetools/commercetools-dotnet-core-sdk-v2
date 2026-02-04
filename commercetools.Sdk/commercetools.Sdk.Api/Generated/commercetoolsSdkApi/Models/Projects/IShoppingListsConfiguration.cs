using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ShoppingListsConfiguration))]
    public partial interface IShoppingListsConfiguration
    {
        long DeleteDaysAfterLastModification { get; set; }

    }
}
