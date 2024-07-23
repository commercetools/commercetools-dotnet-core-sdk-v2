using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitBillingAddressAddedMessage))]
    public partial interface IBusinessUnitBillingAddressAddedMessage : IMessage
    {
        IAddress Address { get; set; }

    }
}
