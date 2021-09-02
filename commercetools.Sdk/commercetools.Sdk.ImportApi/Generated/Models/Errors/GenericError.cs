using commercetools.ImportApi.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    public partial class GenericError : IGenericError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public GenericError()
        {
            this.Code = "Generic";
        }
    }
}
