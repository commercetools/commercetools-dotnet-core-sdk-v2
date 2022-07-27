using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{

    public partial class RecordPagedQueryResponse : IRecordPagedQueryResponse
    {
        public int Limit { get; set; }

        public int Count { get; set; }

        public int Total { get; set; }

        public int Offset { get; set; }

        public List<IRecord> Results { get; set; }
    }
}
