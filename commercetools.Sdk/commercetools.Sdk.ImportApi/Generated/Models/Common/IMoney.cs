using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Common.Money))]
    public partial interface IMoney : ITypedMoney
    {
    }
}
