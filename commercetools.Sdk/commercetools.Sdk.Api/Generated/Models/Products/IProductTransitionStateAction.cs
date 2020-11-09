using commercetools.Api.Models.Products;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductTransitionStateAction))]
    public partial interface IProductTransitionStateAction : IProductUpdateAction
    {
        IStateResourceIdentifier State { get; set;}
        
        bool? Force { get; set;}
    }
}
