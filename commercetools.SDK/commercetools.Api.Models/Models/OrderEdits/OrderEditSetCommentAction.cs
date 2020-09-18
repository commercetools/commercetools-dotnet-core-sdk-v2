using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setComment")]
    public class OrderEditSetCommentAction : OrderEditUpdateAction
    {
        public string Comment { get; set;}
    }
}
