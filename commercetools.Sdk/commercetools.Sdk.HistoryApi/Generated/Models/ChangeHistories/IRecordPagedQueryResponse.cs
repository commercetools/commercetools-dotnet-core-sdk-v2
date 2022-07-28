using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeHistories.RecordPagedQueryResponse))]
    public partial interface IRecordPagedQueryResponse
    {
        int Limit { get; set; }

        int Count { get; set; }

        int Total { get; set; }

        int Offset { get; set; }

        List<IRecord> Results { get; set; }

    }
}
