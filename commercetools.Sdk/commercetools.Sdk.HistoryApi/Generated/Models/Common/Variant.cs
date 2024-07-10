using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class Variant : IVariant
    {
        public int Id { get; set; }

        public string Sku { get; set; }

        public string Key { get; set; }
    }
}
