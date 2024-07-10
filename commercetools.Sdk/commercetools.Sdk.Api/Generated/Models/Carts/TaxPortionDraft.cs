using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class TaxPortionDraft : ITaxPortionDraft
    {
        public string Name { get; set; }

        public decimal Rate { get; set; }

        public IMoney Amount { get; set; }
    }
}
