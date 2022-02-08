using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderCustomerEmailSetMessagePayload))]
    public partial interface IOrderCustomerEmailSetMessagePayload : IOrderMessagePayload
    {
        string Email { get; set; }

        string OldEmail { get; set; }
    }
}
