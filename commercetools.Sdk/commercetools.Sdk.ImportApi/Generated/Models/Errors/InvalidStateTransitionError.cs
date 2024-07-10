using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Errors
{

    public partial class InvalidStateTransitionError : IInvalidStateTransitionError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IProcessingState CurrentState { get; set; }

        public IProcessingState NewState { get; set; }
        public InvalidStateTransitionError()
        {
            this.Code = "InvalidTransition";
        }
    }
}
