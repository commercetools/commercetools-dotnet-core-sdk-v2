using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderCustomerEmailSetMessage))]
    public partial interface IOrderCustomerEmailSetMessage : IMessage
    {
        string Email { get; set; }

        string OldEmail { get; set; }
    }
}
