using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyQuoteRequestUpdate : IMyQuoteRequestUpdate
    {
        public long Version { get; set; }

        public IList<IMyQuoteRequestUpdateAction> Actions { get; set; }
        public IEnumerable<IMyQuoteRequestUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
