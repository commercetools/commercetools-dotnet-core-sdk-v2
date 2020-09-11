using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Common
{
    public class Update 
    {
        public long Version { get; set;}
        
        public List<UpdateAction> Actions { get; set;}
    }
}
