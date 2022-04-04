using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.AddressDraft))]
    public partial interface IAddressDraft : IBaseAddress
    {
        ICustomFieldsDraft Custom { get; set; }
    }
}
