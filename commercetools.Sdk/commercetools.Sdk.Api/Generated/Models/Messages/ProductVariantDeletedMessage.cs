using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;


namespace commercetools.Api.Models.Messages
{
    public partial class ProductVariantDeletedMessage : IProductVariantDeletedMessage
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public ILastModifiedBy LastModifiedBy { get; set;}
        
        public ICreatedBy CreatedBy { get; set;}
        
        public long SequenceNumber { get; set;}
        
        public IReference Resource { get; set;}
        
        public long ResourceVersion { get; set;}
        
        public string Type { get; set;}
        
        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set;}
        
        public IProductVariant Variant { get; set;}
        
        public List<string> RemovedImageUrls { get; set;}
        public ProductVariantDeletedMessage()
        { 
           this.Type = "ProductVariantDeleted";
        }
    }
}
