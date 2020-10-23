using commercetools.Api.Models.Products;
using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public  partial class ProductSetTaxCategoryAction : IProductSetTaxCategoryAction
    {
        public string Action { get; set;}
        
        public ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        public ProductSetTaxCategoryAction()
        { 
           this.Action = "setTaxCategory";
        }
    }
}
