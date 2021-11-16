using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.DiscountCodeInfo))]
    public partial interface IDiscountCodeInfo
    {
        IDiscountCodeKeyReference DiscountCode { get; set; }

        IDiscountCodeState State { get; set; }
    }
}
