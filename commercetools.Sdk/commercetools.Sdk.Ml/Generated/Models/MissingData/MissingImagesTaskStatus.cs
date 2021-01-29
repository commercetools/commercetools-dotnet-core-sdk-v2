using commercetools.Ml.Models.Common;
using commercetools.Ml.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    public partial class MissingImagesTaskStatus : IMissingImagesTaskStatus
    {
        public ITaskStatusEnum State { get; set;}
        
        public DateTime Expires { get; set;}
        
        public IMissingImagesPagedQueryResult Result { get; set;}
    }
}
