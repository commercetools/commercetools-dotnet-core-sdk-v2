using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.ErrorByExtension))]
    public partial interface IErrorByExtension
    {
        string Id { get; set; }

        string Key { get; set; }
    }
}
