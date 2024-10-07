using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyPaymentDraft))]
    public partial interface IMyPaymentDraft
    {
        IMoney AmountPlanned { get; set; }

        IPaymentMethodInfo PaymentMethodInfo { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IMyTransactionDraft Transaction { get; set; }

    }
}
