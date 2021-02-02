using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.Common
{
    public partial class TaskToken : ITaskToken
    {
        public string TaskId { get; set;}
        
        public string UriPath { get; set;}
    }
}
