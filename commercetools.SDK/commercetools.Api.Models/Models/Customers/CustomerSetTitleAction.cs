using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setTitle")]
    public partial class CustomerSetTitleAction : CustomerUpdateAction
    {
        public string Title { get; set;}
        public CustomerSetTitleAction()
        { 
           this.Action = "setTitle";
        }
    }
}
