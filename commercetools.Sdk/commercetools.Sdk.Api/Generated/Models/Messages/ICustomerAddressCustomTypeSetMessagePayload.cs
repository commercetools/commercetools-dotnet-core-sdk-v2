using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomTypeSetMessagePayload))]
    public partial interface ICustomerAddressCustomTypeSetMessagePayload : IMessagePayload
    {
        ICustomFields CustomFields { get; set; }

        string PreviousTypeId { get; set; }

    }
}
