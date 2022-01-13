using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.LastModifiedBy))]
    public partial interface ILastModifiedBy : IClientLogging
    {
    }
}
