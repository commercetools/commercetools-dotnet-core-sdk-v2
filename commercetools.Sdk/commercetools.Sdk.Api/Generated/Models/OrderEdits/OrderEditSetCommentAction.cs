using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderEditSetCommentAction : IOrderEditSetCommentAction
    {
        public string Action { get; set;}
        
        public string Comment { get; set;}
        public OrderEditSetCommentAction()
        { 
           this.Action = "setComment";
        }
    }
}
