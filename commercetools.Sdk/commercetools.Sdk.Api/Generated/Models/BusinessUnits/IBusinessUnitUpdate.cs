using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitUpdate))]
    public partial interface IBusinessUnitUpdate
    {
        long Version { get; set; }

        IList<IBusinessUnitUpdateAction> Actions { get; set; }
        IEnumerable<IBusinessUnitUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
