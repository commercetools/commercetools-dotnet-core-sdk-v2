using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitDefaultBillingAddressSetMessagePayload))]
    public partial interface IBusinessUnitDefaultBillingAddressSetMessagePayload : IMessagePayload
    {
        IAddress Address { get; set; }

    }
}
