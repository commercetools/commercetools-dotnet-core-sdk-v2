using commercetools.Sdk.Api.Models.Me;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.MyBusinessUnitChangeNameAction))]
    public partial interface IMyBusinessUnitChangeNameAction : IMyBusinessUnitUpdateAction
    {
        string Name { get; set; }

    }
}
