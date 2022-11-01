using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetContactEmailAction))]
    public partial interface IMyBusinessUnitSetContactEmailAction : IMyBusinessUnitUpdateAction
    {
        string ContactEmail { get; set; }

    }
}
