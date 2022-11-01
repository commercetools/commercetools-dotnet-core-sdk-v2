using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitBillingAddressRemovedMessage))]
    public partial interface IBusinessUnitBillingAddressRemovedMessage : IMessage
    {
        IAddress Address { get; set; }

    }
}
