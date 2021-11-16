using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.ExternalOAuth))]
    public partial interface IExternalOAuth 
    {
        string Url { get; set;}
        
        string AuthorizationHeader { get; set;}
    }
}
