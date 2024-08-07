using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomerEmailSetMessagePayload))]
    public partial interface IOrderCustomerEmailSetMessagePayload : IOrderMessagePayload
    {
        string Email { get; set; }

        string OldEmail { get; set; }

    }
}
