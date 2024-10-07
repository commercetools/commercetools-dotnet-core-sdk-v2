using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerCustomTypeRemovedMessagePayload))]
    public partial interface ICustomerCustomTypeRemovedMessagePayload : IMessagePayload
    {
        string PreviousTypeId { get; set; }

    }
}
