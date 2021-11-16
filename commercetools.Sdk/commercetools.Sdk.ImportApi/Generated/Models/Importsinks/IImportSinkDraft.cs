using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importsinks
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importsinks.ImportSinkDraft))]
    public partial interface IImportSinkDraft 
    {
        string Key { get; set;}
        
        IImportResourceType ResourceType { get; set;}
    }
}
