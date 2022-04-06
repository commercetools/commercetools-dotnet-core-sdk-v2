using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.DiscountCodeInfo))]
    public partial interface IDiscountCodeInfo
    {
        IDiscountCodeKeyReference DiscountCode { get; set; }

        IDiscountCodeState State { get; set; }
    }
}
