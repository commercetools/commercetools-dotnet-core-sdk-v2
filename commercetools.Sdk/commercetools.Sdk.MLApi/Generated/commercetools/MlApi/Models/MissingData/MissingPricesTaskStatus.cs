using commercetools.MLApi.Models.Common;
using commercetools.MLApi.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    public partial class MissingPricesTaskStatus : IMissingPricesTaskStatus
    {
        public ITaskStatusEnum State { get; set; }

        public DateTime Expires { get; set; }

        public IMissingPricesPagedQueryResult Result { get; set; }
    }
}
