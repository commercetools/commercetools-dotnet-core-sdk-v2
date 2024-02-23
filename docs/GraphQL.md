## GraphQL endpoint

The SDK provides support for the usage of the GraphQL endpoint.

```csharp
IGraphQLResponse response = await _projectApiRoot.Graphql().Post(new GraphQLRequest() { 
        Query = "query($productFilter:String) { products(where: $productFilter) { results { id } } }",
        Variables = new GraphQLVariablesMap()
        {
            {"productFilter", "id = \"" + product.getId() + "\""}
        }
    })
    .ExecuteAsync();
Assert.IsType<JsonElement>(response.Data);
Assert.IsType<string>(((JsonElement)response.Data).GetProperty("products").GetProperty("results")[0].GetProperty("id").GetString());                        
```

## GraphQL package

The SDK comes with a module for enhanced GraphQL support. With the help of [ZeroQL](https://github.com/byme8/ZeroQL)
we generate a type safe query and projection builder. The results will be mapped to the correct response type.

The GraphQLClient class has methods for all available operations in the [GraphQL schema](https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/blob/master/commercetools.Sdk/commercetools.Sdk.GraphQL.Api/schema.graphqls)

```csharp
var client = _projectApiRoot.GraphQLClient();

var variables = new { productFilter = $@"id = ""{productId}""" };
var response = await client.Query(variables, static (i, o) => o.Products(where: i.productFilter, selector: r => new { results = r.Results(product => new { product.Id }) }));
```

The GraphQLDataResponse returns the mapped result data defined as defined by the selector

```csharp
var response = await client.Query(variables, static (i, o) => o.Products(where: i.productFilter, selector: r => new { results = r.Results(product => new { product.Id }) }));

Assert.Null(response.Errors);
Assert.NotNull(response.Data?.results[0].Id);
```
