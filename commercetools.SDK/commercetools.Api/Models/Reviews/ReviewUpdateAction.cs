using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [Discriminator(nameof(Action))]
    public abstract partial class ReviewUpdateAction 
    {
        public string Action { get; set;}
    }
}
