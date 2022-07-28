using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.UnresolvedReferences))]
    public partial interface IUnresolvedReferences
    {
        string Key { get; set; }

        IReferenceType TypeId { get; set; }

    }
}
