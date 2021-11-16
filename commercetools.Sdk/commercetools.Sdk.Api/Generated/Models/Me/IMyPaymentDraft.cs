using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using commercetools.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyPaymentDraft))]
    public partial interface IMyPaymentDraft
    {
        IMoney AmountPlanned { get; set; }

        IPaymentMethodInfo PaymentMethodInfo { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IMyTransactionDraft Transaction { get; set; }
    }
}
