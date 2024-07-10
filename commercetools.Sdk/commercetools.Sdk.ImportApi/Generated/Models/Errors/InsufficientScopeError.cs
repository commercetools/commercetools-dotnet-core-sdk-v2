using commercetools.Sdk.ImportApi.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Errors
{

    public partial class InsufficientScopeError : IInsufficientScopeError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public InsufficientScopeError()
        {
            this.Code = "insufficient_scope";
        }
    }
}
