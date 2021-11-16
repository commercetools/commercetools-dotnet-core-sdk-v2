using System;


namespace commercetools.Api.Models.Products
{
    public partial class Attribute : IAttribute
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
