using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.BusinessUnitConfiguration))]
    public partial interface IBusinessUnitConfiguration
    {
        IBusinessUnitConfigurationStatus MyBusinessUnitStatusOnCreation { get; set; }

    }
}
