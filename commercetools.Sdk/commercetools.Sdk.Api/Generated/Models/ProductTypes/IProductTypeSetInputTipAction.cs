using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeSetInputTipAction))]
    public partial interface IProductTypeSetInputTipAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set;}
        
        ILocalizedString InputTip { get; set;}
    }
}
