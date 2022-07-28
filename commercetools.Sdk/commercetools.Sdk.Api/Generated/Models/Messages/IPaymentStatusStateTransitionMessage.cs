using commercetools.Sdk.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentStatusStateTransitionMessage))]
    public partial interface IPaymentStatusStateTransitionMessage : IMessage
    {
        IStateReference State { get; set; }

        bool Force { get; set; }

    }
}
