using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListResourceIdentifier))]
    public partial interface IShoppingListResourceIdentifier : IResourceIdentifier
    {
        new IReferenceTypeId TypeId { get; set; }

        new string Id { get; set; }

        new string Key { get; set; }

    }
}
