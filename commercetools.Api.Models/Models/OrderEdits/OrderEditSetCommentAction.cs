using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class OrderEditSetCommentAction : OrderEditUpdateAction
    {
        public string Comment { get; set;}
    }
}
