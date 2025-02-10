using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetBusinessUnitAction))]
    public partial interface IShoppingListSetBusinessUnitAction : IShoppingListUpdateAction
    {
        IBusinessUnitResourceIdentifier BusinessUnit { get; set; }

    }
}
