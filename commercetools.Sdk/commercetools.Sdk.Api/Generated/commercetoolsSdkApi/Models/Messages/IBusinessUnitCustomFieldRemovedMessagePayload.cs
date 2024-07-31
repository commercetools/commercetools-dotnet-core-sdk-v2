using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomFieldRemovedMessagePayload))]
    public partial interface IBusinessUnitCustomFieldRemovedMessagePayload : IMessagePayload
    {
        string Name { get; set; }

    }
}
