using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Sdk.HistoryApi.Models.Labels;
using System.Collections.Generic;
using System.Linq;

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

        public IList<IChange> Changes { get; set; }

        public IEnumerable<IChange> ChangesEnumerable { set => Changes = value.ToList(); }

        public IResourceIdentifier Resource { get; set; }

        public IList<IKeyReference> Stores { get; set; }

        public IEnumerable<IKeyReference> StoresEnumerable { set => Stores = value.ToList(); }

        public IKeyReference BusinessUnit { get; set; }

        public bool WithoutChanges { get; set; }
    }
}
