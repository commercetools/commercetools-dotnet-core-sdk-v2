using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyPaymentSetMethodInfoNameAction))]
    public partial interface IMyPaymentSetMethodInfoNameAction : IMyPaymentUpdateAction
    {
        ILocalizedString Name { get; set; }
    }
}
