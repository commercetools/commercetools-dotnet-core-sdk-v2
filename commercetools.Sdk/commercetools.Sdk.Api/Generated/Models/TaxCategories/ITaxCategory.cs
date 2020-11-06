using commercetools.Api.Models.Common;
using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.TaxCategory))]
    public partial interface ITaxCategory : IBaseResource
    {
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        string Name { get; set;}
        
        string Description { get; set;}
        
        List<ITaxRate> Rates { get; set;}
        
        string Key { get; set;}
    }
}
