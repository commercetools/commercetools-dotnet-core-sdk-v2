using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importsinks
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importsinks.ImportSinkUpdateDraft))]
    public partial interface IImportSinkUpdateDraft
    {
        long Version { get; set; }

        IImportResourceType ResourceType { get; set; }
    }
}
