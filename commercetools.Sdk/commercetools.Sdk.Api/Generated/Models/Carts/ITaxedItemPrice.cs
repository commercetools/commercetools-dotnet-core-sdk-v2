using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.TaxedItemPrice))]
    public partial interface ITaxedItemPrice
    {
        ITypedMoney TotalNet { get; set; }

        ITypedMoney TotalGross { get; set; }

        ITypedMoney TotalTax { get; set; }
    }
}
