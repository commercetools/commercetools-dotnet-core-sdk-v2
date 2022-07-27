using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Sdk.HistoryApi.Models.Labels;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{

    public partial class Record : IRecord
    {
        public int Version { get; set; }

        public int PreviousVersion { get; set; }

        public string Type { get; set; }

        public IModifiedBy ModifiedBy { get; set; }

        public string ModifiedAt { get; set; }

        public ILabel Label { get; set; }

        public ILabel PreviousLabel { get; set; }

        public List<IChange> Changes { get; set; }

        public IReference Resource { get; set; }

        public List<IKeyReference> Stores { get; set; }

        public bool WithoutChanges { get; set; }
    }
}
