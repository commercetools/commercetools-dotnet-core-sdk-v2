using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderBillingAddressSetMessagePayload))]
    public partial interface IOrderBillingAddressSetMessagePayload : IOrderMessagePayload
    {
        IAddress Address { get; set; }

        IAddress OldAddress { get; set; }

    }
}
