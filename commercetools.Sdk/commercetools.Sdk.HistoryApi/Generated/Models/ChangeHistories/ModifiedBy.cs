using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{

    public partial class ModifiedBy : IModifiedBy
    {
        public string Id { get; set; }

        public string Type { get; set; }

        public string ClientId { get; set; }

        public string AnonymousId { get; set; }

        public IReference Customer { get; set; }

        public IReference Associate { get; set; }

        public bool IsPlatformClient { get; set; }
    }
}
