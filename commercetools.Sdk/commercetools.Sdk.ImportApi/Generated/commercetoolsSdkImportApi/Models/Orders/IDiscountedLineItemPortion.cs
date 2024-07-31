using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.DiscountedLineItemPortion))]
    public partial interface IDiscountedLineItemPortion
    {
        ICartDiscountKeyReference Discount { get; set; }

        IMoney DiscountedAmount { get; set; }

    }
}
