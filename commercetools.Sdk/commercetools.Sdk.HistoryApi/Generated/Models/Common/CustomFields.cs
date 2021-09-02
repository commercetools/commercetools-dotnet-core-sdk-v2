using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class CustomFields : ICustomFields
    {
        public IReference Type { get; set; }

        public Object Fields { get; set; }
    }
}
