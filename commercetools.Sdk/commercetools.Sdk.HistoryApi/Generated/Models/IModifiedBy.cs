using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ModifiedBy))]
    public partial interface IModifiedBy
    {
        string Id { get; set; }

        string Type { get; set; }

        IReference Customer { get; set; }

        string AnonymousId { get; set; }

        string ClientId { get; set; }

        bool IsPlatformClient { get; set; }
    }
}
