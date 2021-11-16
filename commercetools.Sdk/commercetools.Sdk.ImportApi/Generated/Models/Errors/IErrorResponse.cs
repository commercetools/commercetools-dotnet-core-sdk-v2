using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.ErrorResponse))]
    public partial interface IErrorResponse 
    {
        int StatusCode { get; set;}
        
        string Message { get; set;}
        
        string Error { get; set;}
        
        string Error_description { get; set;}
        
        List<IErrorObject> Errors { get; set;}
    }
}
