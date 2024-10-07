using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitReference))]
    public partial interface IBusinessUnitReference : IReference
    {
        IBusinessUnit Obj { get; set; }

        new string Id { get; set; }

    }
}
