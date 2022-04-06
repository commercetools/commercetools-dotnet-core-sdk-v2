using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importsinks
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importsinks.ImportSinkDraft))]
    public partial interface IImportSinkDraft
    {
        string Key { get; set; }

        IImportResourceType ResourceType { get; set; }
    }
}
