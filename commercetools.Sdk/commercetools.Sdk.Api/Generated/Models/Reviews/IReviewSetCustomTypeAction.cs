using commercetools.Api.Models.Reviews;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Api.Models.Reviews.ReviewSetCustomTypeAction))]
    public interface IReviewSetCustomTypeAction : IReviewUpdateAction
    {
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
