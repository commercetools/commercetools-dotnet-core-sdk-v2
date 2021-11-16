using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.InvalidStateTransitionError))]
    public partial interface IInvalidStateTransitionError : IErrorObject
    {
        IProcessingState CurrentState { get; set;}
        
        IProcessingState NewState { get; set;}
    }
}
