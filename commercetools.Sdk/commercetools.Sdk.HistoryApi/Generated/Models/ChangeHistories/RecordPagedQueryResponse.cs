using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{

    public partial class RecordPagedQueryResponse : IRecordPagedQueryResponse
    {
        public int Limit { get; set; }

        public int Count { get; set; }

        public int Total { get; set; }

        public int Offset { get; set; }

        public IList<IRecord> Results { get; set; }
        public IEnumerable<IRecord> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
