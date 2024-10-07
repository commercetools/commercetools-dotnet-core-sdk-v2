using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.CustomLineItemTaxedPrice))]
    public partial interface ICustomLineItemTaxedPrice
    {
        ITypedMoney TotalNet { get; set; }

        ITypedMoney TotalGross { get; set; }

    }
}
