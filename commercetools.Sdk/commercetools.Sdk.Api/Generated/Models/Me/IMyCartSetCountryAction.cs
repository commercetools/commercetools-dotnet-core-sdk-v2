using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartSetCountryAction))]
    public partial interface IMyCartSetCountryAction : IMyCartUpdateAction
    {
        string Country { get; set; }
    }
}
