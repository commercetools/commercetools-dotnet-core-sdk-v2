using commercetools.Sdk.Api.Models.BusinessUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitUpdate : IMyBusinessUnitUpdate
    {
        public long Version { get; set; }

        public IList<IBusinessUnitUpdateAction> Actions { get; set; }
        public IEnumerable<IBusinessUnitUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
