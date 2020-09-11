using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CustomObjects
{
    public class CustomObjectReference : Reference
    {
        public CustomObject Obj { get; set;}
    }
}
