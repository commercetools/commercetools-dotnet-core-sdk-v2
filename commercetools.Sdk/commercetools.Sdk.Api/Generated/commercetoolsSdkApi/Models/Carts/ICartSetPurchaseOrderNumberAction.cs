using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetPurchaseOrderNumberAction))]
    public partial interface ICartSetPurchaseOrderNumberAction : ICartUpdateAction
    {
        string PurchaseOrderNumber { get; set; }

    }
}
