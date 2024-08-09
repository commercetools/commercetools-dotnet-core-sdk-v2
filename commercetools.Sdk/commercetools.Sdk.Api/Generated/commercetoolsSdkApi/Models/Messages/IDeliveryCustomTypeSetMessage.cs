using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryCustomTypeSetMessage))]
    public partial interface IDeliveryCustomTypeSetMessage : IOrderMessage
    {
        ICustomFields CustomFields { get; set; }

        string PreviousTypeId { get; set; }

        string DeliveryId { get; set; }

    }
}
