using commercetools.Sdk.Api.Models.BusinessUnits;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitUpdate))]
    public partial interface IMyBusinessUnitUpdate
    {
        long Version { get; set; }

        List<IBusinessUnitUpdateAction> Actions { get; set; }

    }
}
