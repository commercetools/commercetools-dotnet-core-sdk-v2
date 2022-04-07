using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Sdk.HistoryApi.Models.Labels;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeHistories.Record))]
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

        List<IKeyReference> Stores { get; set; }

        bool WithoutChanges { get; set; }
    }
}
