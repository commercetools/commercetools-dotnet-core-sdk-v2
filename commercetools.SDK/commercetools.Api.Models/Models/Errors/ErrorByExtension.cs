using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class ErrorByExtension 
    {
        public string Id { get; set;}
        
        public string Key { get; set;}
    }
}
