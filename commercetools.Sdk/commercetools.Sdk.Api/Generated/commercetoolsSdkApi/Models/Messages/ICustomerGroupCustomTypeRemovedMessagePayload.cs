using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomTypeRemovedMessagePayload))]
    public partial interface ICustomerGroupCustomTypeRemovedMessagePayload : IMessagePayload
    {
        string OldTypeId { get; set; }

    }
}
