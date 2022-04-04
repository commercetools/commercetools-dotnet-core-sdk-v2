using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartSetLocaleAction))]
    public partial interface IMyCartSetLocaleAction : IMyCartUpdateAction
    {
        string Locale { get; set; }
    }
}
