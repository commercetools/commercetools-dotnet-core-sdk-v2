using commercetools.Sdk.MLApi.Models.Common;
using System;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    public partial class MissingPricesTaskStatus : IMissingPricesTaskStatus
    {
        public ITaskStatusEnum State { get; set; }

        public DateTime Expires { get; set; }

        public IMissingPricesPagedQueryResult Result { get; set; }
    }
}
