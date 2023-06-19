using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeParentUnitAction))]
    public partial interface IMyBusinessUnitChangeParentUnitAction : IMyBusinessUnitUpdateAction
    {
        IBusinessUnitResourceIdentifier ParentUnit { get; set; }

    }
}
