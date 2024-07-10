using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Prices
{

    public partial class SubRate : ISubRate
    {
        public string Name { get; set; }

        public decimal Amount { get; set; }
    }
}
