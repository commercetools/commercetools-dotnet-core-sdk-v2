using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitDefaultShippingAddressSetMessagePayload))]
    public partial interface IBusinessUnitDefaultShippingAddressSetMessagePayload : IMessagePayload
    {
        IAddress Address { get; set; }

    }
}
