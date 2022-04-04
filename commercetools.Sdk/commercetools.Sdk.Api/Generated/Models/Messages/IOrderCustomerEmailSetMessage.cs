using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomerEmailSetMessage))]
    public partial interface IOrderCustomerEmailSetMessage : IOrderMessage
    {
        string Email { get; set; }

        string OldEmail { get; set; }
    }
}
