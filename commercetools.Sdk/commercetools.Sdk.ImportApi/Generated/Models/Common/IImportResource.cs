using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.ImportResource))]
    public partial interface IImportResource
    {
        string Key { get; set; }

    }
}
