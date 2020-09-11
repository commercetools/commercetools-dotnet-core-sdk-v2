using commercetools.Api.Models.Common;
using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Reviews
{
    public class ReviewReference : Reference
    {
        public Review Obj { get; set;}
    }
}
