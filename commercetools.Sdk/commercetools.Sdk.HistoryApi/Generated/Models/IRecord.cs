using commercetools.HistoryApi.Models;
using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using commercetools.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Record))]
    public partial interface IRecord
    {
        int Version { get; set; }

        int PreviousVersion { get; set; }

        string Type { get; set; }

        IModifiedBy ModifiedBy { get; set; }

        string ModifiedAt { get; set; }

        ILabel Label { get; set; }

        ILabel PreviousLabel { get; set; }

        List<IChange> Changes { get; set; }

        IReference Resource { get; set; }

        bool WithoutChanges { get; set; }
    }
}
