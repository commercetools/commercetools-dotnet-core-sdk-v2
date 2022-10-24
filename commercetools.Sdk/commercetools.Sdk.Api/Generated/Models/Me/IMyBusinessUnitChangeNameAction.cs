using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeNameAction))]
    public partial interface IMyBusinessUnitChangeNameAction : IMyBusinessUnitUpdateAction
    {
        string Name { get; set; }

    }
}
