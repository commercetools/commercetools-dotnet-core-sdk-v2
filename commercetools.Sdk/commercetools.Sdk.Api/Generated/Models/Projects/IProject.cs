using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.Project))]
    public partial interface IProject 
    {
        long Version { get; set;}
        
        string Key { get; set;}
        
        string Name { get; set;}
        
        List<string> Countries { get; set;}
        
        List<string> Currencies { get; set;}
        
        List<string> Languages { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        string TrialUntil { get; set;}
        
        IMessageConfiguration Messages { get; set;}
        
        IShippingRateInputType ShippingRateInputType { get; set;}
        
        IExternalOAuth ExternalOAuth { get; set;}
        
        ICartsConfiguration Carts { get; set;}
        
        ISearchIndexingConfiguration SearchIndexing { get; set;}
    }
}
