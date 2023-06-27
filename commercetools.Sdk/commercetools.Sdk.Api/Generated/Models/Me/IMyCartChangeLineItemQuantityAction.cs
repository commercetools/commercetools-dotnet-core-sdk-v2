using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartChangeLineItemQuantityAction))]
    public partial interface IMyCartChangeLineItemQuantityAction : IMyCartUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        long Quantity { get; set; }

        IMoney ExternalPrice { get; set; }

        IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }

    }
}
