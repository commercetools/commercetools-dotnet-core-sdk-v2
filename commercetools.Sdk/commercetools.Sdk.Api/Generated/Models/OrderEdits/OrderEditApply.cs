using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderEditApply : IOrderEditApply
    {
        public long EditVersion { get; set; }

        public long ResourceVersion { get; set; }
    }
}
