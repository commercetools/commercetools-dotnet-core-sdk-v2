using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Errors
{
    public class ReferenceExistsError : ErrorObject
    {
        public ReferenceTypeId ReferencedBy { get; set;}
    }
}
