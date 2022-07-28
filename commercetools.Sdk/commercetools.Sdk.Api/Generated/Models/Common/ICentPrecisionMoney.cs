using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.CentPrecisionMoney))]
    public partial interface ICentPrecisionMoney : ITypedMoney
    {
        new int FractionDigits { get; set; }

    }
}
