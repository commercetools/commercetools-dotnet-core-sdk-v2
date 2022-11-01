using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressAddedMessagePayload))]
    public partial interface IBusinessUnitAddressAddedMessagePayload : IMessagePayload
    {
        IAddress Address { get; set; }

    }
}
