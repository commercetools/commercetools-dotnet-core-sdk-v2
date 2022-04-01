using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ExternalLineItemTotalPrice))]
    public partial interface IExternalLineItemTotalPrice
    {
        IMoney Price { get; set; }

        IMoney TotalPrice { get; set; }
    }
}
