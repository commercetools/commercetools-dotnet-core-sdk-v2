using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetAssociatesAction))]
    public partial interface IBusinessUnitSetAssociatesAction : IBusinessUnitUpdateAction
    {
        IList<IAssociateDraft> Associates { get; set; }
        IEnumerable<IAssociateDraft> AssociatesEnumerable { set => Associates = value.ToList(); }


    }
}
