using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyPaymentChangeAmountPlannedAction))]
    public partial interface IMyPaymentChangeAmountPlannedAction : IMyPaymentUpdateAction
    {
        IMoney Amount { get; set; }
    }
}
