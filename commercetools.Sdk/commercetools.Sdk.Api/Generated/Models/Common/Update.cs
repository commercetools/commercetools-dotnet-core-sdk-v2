using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public partial class Update : IUpdate
    {
        public long Version { get; set; }

        public List<IUpdateAction> Actions { get; set; }
    }
}
