using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryCustomTypeSetMessagePayload))]
    public partial interface IDeliveryCustomTypeSetMessagePayload : IOrderMessagePayload
    {
        ICustomFields CustomFields { get; set; }

        string PreviousTypeId { get; set; }

        string DeliveryId { get; set; }

    }
}
