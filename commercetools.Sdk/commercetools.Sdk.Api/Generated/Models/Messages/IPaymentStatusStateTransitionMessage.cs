using commercetools.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.PaymentStatusStateTransitionMessage))]
    public partial interface IPaymentStatusStateTransitionMessage : IMessage
    {
        IStateReference State { get; set; }

        bool Force { get; set; }
    }
}
