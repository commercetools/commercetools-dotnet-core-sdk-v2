using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyPaymentSetMethodInfoMethodAction))]
    public partial interface IMyPaymentSetMethodInfoMethodAction : IMyPaymentUpdateAction
    {
        string Method { get; set;}
    }
}
