using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderImportedMessage))]
    public partial interface IOrderImportedMessage : IOrderMessage
    {
        IOrder Order { get; set; }

    }
}
