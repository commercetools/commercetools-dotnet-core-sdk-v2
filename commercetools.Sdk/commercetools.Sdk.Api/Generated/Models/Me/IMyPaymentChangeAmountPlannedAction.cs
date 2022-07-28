using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyPaymentChangeAmountPlannedAction))]
    public partial interface IMyPaymentChangeAmountPlannedAction : IMyPaymentUpdateAction
    {
        IMoney Amount { get; set; }

    }
}
