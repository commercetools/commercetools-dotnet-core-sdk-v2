using commercetools.MLApi.Models.Common;
using System;


namespace commercetools.MLApi.Models.MissingData
{
    public partial class MissingDataTaskStatus : IMissingDataTaskStatus
    {
        public ITaskStatusEnum State { get; set;}
        
        public DateTime Expires { get; set;}
        
        public IMissingAttributesPagedQueryResult Result { get; set;}
    }
}
