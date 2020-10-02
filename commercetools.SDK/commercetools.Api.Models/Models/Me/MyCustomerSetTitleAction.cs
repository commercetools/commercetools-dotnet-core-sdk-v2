using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setTitle")]
    public partial class MyCustomerSetTitleAction : MyCustomerUpdateAction
    {
        public string Title { get; set;}
        public MyCustomerSetTitleAction()
        { 
           this.Action = "setTitle";
        }
    }
}
