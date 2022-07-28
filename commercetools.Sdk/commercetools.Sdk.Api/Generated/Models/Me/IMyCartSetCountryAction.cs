using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartSetCountryAction))]
    public partial interface IMyCartSetCountryAction : IMyCartUpdateAction
    {
        string Country { get; set; }

    }
}
