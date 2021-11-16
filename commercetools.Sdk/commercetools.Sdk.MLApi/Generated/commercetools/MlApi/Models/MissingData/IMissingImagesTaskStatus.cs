using commercetools.MLApi.Models.Common;
using commercetools.MLApi.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingImagesTaskStatus))]
    public partial interface IMissingImagesTaskStatus 
    {
        ITaskStatusEnum State { get; set;}
        
        DateTime Expires { get; set;}
        
        IMissingImagesPagedQueryResult Result { get; set;}
    }
}
