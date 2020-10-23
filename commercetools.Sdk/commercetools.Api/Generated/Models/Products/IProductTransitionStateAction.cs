using commercetools.Api.Generated.Models.Products;
using commercetools.Api.Generated.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductTransitionStateAction : IProductUpdateAction
    {
        IStateResourceIdentifier State { get; set;}
        
        bool Force { get; set;}
    }
}
