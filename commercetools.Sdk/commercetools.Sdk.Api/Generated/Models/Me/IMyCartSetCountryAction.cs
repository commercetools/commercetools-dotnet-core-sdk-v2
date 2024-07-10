using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartSetCountryAction))]
    public partial interface IMyCartSetCountryAction : IMyCartUpdateAction
    {
        string Country { get; set; }

    }
}
