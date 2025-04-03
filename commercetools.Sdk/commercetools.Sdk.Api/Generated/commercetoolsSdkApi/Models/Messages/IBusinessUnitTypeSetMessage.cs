using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitTypeSetMessage))]
    public partial interface IBusinessUnitTypeSetMessage : IMessage
    {
        IBusinessUnitKeyReference ParentUnit { get; set; }

        IBusinessUnitKeyReference OldParentUnit { get; set; }

        IBusinessUnitType UnitType { get; set; }

        IBusinessUnitType OldUnitType { get; set; }

    }
}
