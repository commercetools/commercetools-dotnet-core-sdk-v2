using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Reviews
{
    public class ReviewSetCustomFieldAction : ReviewUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
