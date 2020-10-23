using commercetools.Api.Generated.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Errors
{
    public interface IErrorResponse 
    {
        int StatusCode { get; set;}
        
        string Message { get; set;}
        
        string Error { get; set;}
        
        string Error_description { get; set;}
        
        List<IErrorObject> Errors { get; set;}
    }
}
