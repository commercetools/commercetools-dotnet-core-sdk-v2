using commercetools.Ml.Models.Common;
using commercetools.Ml.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.MissingDataTaskStatus))]
    public partial interface IMissingDataTaskStatus 
    {
        ITaskStatusEnum State { get; set;}
        
        DateTime Expires { get; set;}
        
        IMissingAttributesPagedQueryResult Result { get; set;}
    }
}
