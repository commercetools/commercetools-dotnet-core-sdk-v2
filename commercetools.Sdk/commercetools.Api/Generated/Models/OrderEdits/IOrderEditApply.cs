using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.OrderEdits
{
    public interface IOrderEditApply 
    {
        int EditVersion { get; set;}
        
        int ResourceVersion { get; set;}
    }
}
