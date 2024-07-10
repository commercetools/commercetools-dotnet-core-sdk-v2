using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Common
{

    public partial class Update : IUpdate
    {
        public long Version { get; set; }

        public IList<IUpdateAction> Actions { get; set; }
        public IEnumerable<IUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
