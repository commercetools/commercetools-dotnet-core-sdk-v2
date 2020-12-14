using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class ResourceDeletedDelivery : IResourceDeletedDelivery
    {
        public string ProjectKey { get; set;}
        
        public string NotificationType { get; set;}
        
        public IReference Resource { get; set;}
        
        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set;}
        
        public long Version { get; set;}
        
        public DateTime ModifiedAt { get; set;}
        
        public bool? DataErasure { get; set;}
        public ResourceDeletedDelivery()
        { 
           this.NotificationType = "ResourceDeleted";
        }
    }
}
