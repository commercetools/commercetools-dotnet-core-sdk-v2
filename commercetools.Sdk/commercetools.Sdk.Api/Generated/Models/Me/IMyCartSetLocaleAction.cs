using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartSetLocaleAction))]
    public partial interface IMyCartSetLocaleAction : IMyCartUpdateAction
    {
        string Locale { get; set;}
    }
}
