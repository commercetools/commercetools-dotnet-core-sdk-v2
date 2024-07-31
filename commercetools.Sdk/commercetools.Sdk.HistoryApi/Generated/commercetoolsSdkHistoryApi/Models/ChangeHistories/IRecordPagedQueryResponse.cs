using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeHistories.RecordPagedQueryResponse))]
    public partial interface IRecordPagedQueryResponse
    {
        int Limit { get; set; }

        int Count { get; set; }

        int Total { get; set; }

        int Offset { get; set; }

        IList<IRecord> Results { get; set; }

        IEnumerable<IRecord> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
