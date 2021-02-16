using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.Common
{
    [DeserializeAs(typeof(commercetools.Ml.Models.Common.TaskToken))]
    public partial interface ITaskToken 
    {
        string TaskId { get; set;}
        
        string UriPath { get; set;}
    }
}
