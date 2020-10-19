using commercetools.Api.Models.Products;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("transitionState")]
    public partial class ProductTransitionStateAction : ProductUpdateAction
    {
        public StateResourceIdentifier State { get; set;}
        
        public bool Force { get; set;}
        public ProductTransitionStateAction()
        { 
           this.Action = "transitionState";
        }
    }
}
