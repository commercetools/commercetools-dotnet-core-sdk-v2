using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomTypeRemovedMessagePayload))]
    public partial interface IOrderCustomTypeRemovedMessagePayload : IOrderMessagePayload
    {
        string PreviousTypeId { get; set; }

    }
}
