using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{

    public partial class ParcelChangeValue : IParcelChangeValue
    {
        public string Id { get; set; }

        public string CreatedAt { get; set; }
    }
}
