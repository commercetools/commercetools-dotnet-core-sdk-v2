using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public partial class Update 
    {
        public long Version { get; set;}
        
        public List<UpdateAction> Actions { get; set;}
    }
}
