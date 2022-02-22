using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.SearchIndexingConfigurationValues))]
    public partial interface ISearchIndexingConfigurationValues
    {
        ISearchIndexingConfigurationStatus Status { get; set; }

        DateTime LastModifiedAt { get; set; }

        string LastModifiedBy { get; set; }
    }
}
