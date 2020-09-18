using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public class OrderEditApply 
    {
        public int EditVersion { get; set;}
        
        public int ResourceVersion { get; set;}
    }
}
