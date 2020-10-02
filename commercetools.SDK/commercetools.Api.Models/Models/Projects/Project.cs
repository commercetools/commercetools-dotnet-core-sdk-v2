using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public partial class Project 
    {
        public long Version { get; set;}
        
        public string Key { get; set;}
        
        public string Name { get; set;}
        
        public List<string> Countries { get; set;}
        
        public List<string> Currencies { get; set;}
        
        public List<string> Languages { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public string TrialUntil { get; set;}
        
        public MessageConfiguration Messages { get; set;}
        
        public ShippingRateInputType ShippingRateInputType { get; set;}
        
        public ExternalOAuth ExternalOAuth { get; set;}
        
        public CartsConfiguration Carts { get; set;}
    }
}
