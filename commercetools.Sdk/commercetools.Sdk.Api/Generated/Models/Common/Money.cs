using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Common
{

    public partial class Money : IMoney
    {
        public long CentAmount { get; set; }

        public string CurrencyCode { get; set; }
    }
}
