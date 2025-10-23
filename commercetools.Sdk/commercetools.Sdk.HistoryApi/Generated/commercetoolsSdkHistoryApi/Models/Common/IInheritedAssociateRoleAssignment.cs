using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.InheritedAssociateRoleAssignment))]
    public partial interface IInheritedAssociateRoleAssignment
    {
        IAssociateRoleKeyReference AssociateRole { get; set; }

        IBusinessUnitKeyReference Source { get; set; }

    }
}
