using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoNameAction))]
    public partial interface IMyPaymentSetMethodInfoNameAction : IMyPaymentUpdateAction
    {
        ILocalizedString Name { get; set; }

    }
}
