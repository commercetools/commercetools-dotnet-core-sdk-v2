using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Common.ImportResource))]
    public partial interface IImportResource
    {
        string Key { get; set; }
    }
}
