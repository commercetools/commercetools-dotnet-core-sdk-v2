using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.Address))]
    public partial interface IAddress : IBaseAddress
    {
        ICustomFields Custom { get; set; }

    }
}
