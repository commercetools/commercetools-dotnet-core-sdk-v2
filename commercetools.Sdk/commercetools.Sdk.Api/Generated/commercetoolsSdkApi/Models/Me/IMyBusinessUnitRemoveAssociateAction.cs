using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveAssociateAction))]
    public partial interface IMyBusinessUnitRemoveAssociateAction : IMyBusinessUnitUpdateAction
    {
        ICustomerResourceIdentifier Customer { get; set; }

    }
}
