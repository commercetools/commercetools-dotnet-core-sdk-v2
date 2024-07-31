using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitNameChangedMessagePayload))]
    public partial interface IBusinessUnitNameChangedMessagePayload : IMessagePayload
    {
        string Name { get; set; }

    }
}
