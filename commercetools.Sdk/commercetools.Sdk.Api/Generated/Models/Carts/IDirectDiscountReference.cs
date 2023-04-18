using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.DirectDiscountReference))]
    public partial interface IDirectDiscountReference : IReference
    {
        new string Id { get; set; }

    }
}
