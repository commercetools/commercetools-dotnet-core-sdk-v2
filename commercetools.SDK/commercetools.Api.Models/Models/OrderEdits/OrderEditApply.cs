using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderEditApply 
    {
        public int EditVersion { get; set;}
        
        public int ResourceVersion { get; set;}
    }
}
