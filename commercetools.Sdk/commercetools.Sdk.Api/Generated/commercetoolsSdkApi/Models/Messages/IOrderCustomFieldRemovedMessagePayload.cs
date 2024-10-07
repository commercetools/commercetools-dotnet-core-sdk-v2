using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomFieldRemovedMessagePayload))]
    public partial interface IOrderCustomFieldRemovedMessagePayload : IOrderMessagePayload
    {
        string Name { get; set; }

    }
}
