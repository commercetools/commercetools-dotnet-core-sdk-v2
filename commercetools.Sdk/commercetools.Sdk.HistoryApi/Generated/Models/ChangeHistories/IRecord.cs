using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Sdk.HistoryApi.Models.Labels;
using System.Collections.Generic;
using System.Linq;
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

        IList<IChange> Changes { get; set; }
        IEnumerable<IChange> ChangesEnumerable { set => Changes = value.ToList(); }


        IReference Resource { get; set; }

        IList<IKeyReference> Stores { get; set; }
        IEnumerable<IKeyReference> StoresEnumerable { set => Stores = value.ToList(); }


        bool WithoutChanges { get; set; }

    }
}
