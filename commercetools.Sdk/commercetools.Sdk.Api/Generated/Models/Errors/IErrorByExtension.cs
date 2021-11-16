using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.ErrorByExtension))]
    public partial interface IErrorByExtension 
    {
        string Id { get; set;}
        
        string Key { get; set;}
    }
}
