using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class ConcurrentModificationError : IConcurrentModificationError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public long? CurrentVersion { get; set; }
        public ConcurrentModificationError()
        {
            this.Code = "ConcurrentModification";
        }
    }
}
