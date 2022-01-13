using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.CreatedBy))]
    public partial interface ICreatedBy : IClientLogging
    {
    }
}
