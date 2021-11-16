using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Api.Models.GraphQl.GraphQLRequest))]
    public partial interface IGraphQLRequest 
    {
        string Query { get; set;}
        
        string OperationName { get; set;}
        
        IGraphQLVariablesMap Variables { get; set;}
    }
}
