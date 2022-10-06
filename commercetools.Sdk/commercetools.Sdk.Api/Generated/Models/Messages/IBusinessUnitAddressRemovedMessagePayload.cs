using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressRemovedMessagePayload))]
    public partial interface IBusinessUnitAddressRemovedMessagePayload : IMessagePayload
    {
        IAddress Address { get; set; }

    }
}
