using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models
{
    public partial class ModifiedBy : IModifiedBy
    {
        public string Id { get; set; }

        public string Type { get; set; }

        public IReference Customer { get; set; }

        public string AnonymousId { get; set; }

        public string ClientId { get; set; }

        public bool IsPlatformClient { get; set; }
    }
}
