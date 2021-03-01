using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.SearchIndexingConfigurationValues))]
    public partial interface ISearchIndexingConfigurationValues 
    {
        string Status { get; set;}
    }
}
