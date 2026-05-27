using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListReference))]
    public partial interface IShoppingListReference : IReference
    {
        new IReferenceTypeId TypeId { get; set; }

        IShoppingList Obj { get; set; }

        new string Id { get; set; }

    }
}
