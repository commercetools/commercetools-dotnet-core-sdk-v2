using commercetools.Sdk.HistoryApi.Models.ChangeHistories;
using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Sdk.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
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


        IResourceIdentifier Resource { get; set; }

        IList<IKeyReference> Stores { get; set; }
        IEnumerable<IKeyReference> StoresEnumerable { set => Stores = value.ToList(); }


        IKeyReference BusinessUnit { get; set; }

        bool WithoutChanges { get; set; }

    }
}
