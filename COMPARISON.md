# Comparison between DotNet Core SDK V2 and V1
## Why I should use V2 SDK
The SDK [V2](/) has some features which is not exists in [V1](https://github.com/commercetools/commercetools-dotnet-core-sdk) like:
* V1 supports only the Composable Commerce Api, but V2 has different packages to support things like Composable Commerce, Import API, Machine Learning API and History API.
* V2 SDK supports ME endpoints.
* V2 SDK is auto generated from RAML files like other SDKS which means less maintainability and it will be always up-to-date with backend new features.
* V2 SDK is faster than V1 SDK as it’s using System.Text.Json in Serialization and Deserialisation
* In SDK V1, you only have to configure clients and inject them in the service container in the App Start, but SDK V2, you can use the injected clients or use the ClientFactory to create clients on the fly.

## Comparison of SDK Installation
| Package                | V2                                                     | V1                                              |
|------------------------|--------------------------------------------------------|-------------------------------------------------|
| Composable Commerce    | ```dotnet add package commercetools.Sdk.Api```         | ```dotnet add package commercetools.Sdk.All```  |
| Import API             | ```dotnet add package commercetools.Sdk.ImportApi```   |                                                 |
| ML API                 | ```dotnet add package commercetools.Sdk.MLApi```       |                                                 |
| History API            | ```dotnet add package commercetools.Sdk.HistoryApi```  |                                                 |

## Comparison of SDK Services Configuration
After packages installation, you have to configure services using Dependency Injection Setup in the application Startup.cs

| Package                | V2                                                                              | V1                                    |
|------------------------|---------------------------------------------------------------------------------|---------------------------------------|
| Composable Commerce    | ```services.UseCommercetoolsApi(this.configuration, "Client");```               | ```services.UseCommercetools(```
|                        |                                                                                 |  ```this.configuration,"Client");```  |
| Import API             | ```services.UseCommercetoolsImportApi(this.configuration, "ImportClient");```   |                                       |
| ML API                 | ```services.UseCommercetoolsMLApi(this.configuration, "MLClient");```           |                                       |
| History API            | ```services.UseCommercetoolsHistoryApi(this.configuration, "HistoryClient");``` |                                       |

## Comparison of how to make requests to Composable Commerce
```c#
    // Create CategoryDraft
    var categoryDraft = new CategoryDraft
                {
                    Name = new LocalizedString {{"en", "Name"}},
                    Slug = new LocalizedString {{"en", "Slug"}},
                    Key = "Key"
                };
    // Create CategoryUpdate
    var action = new CategoryChangeNameAction
                    {
                        Name = new LocalizedString {{"en", "newName"}}
                    };
    var categoryUpdate = new CategoryUpdate
                    {
                        Version = category.Version,
                        Actions = new List<ICategoryUpdateAction> { action }
                    };
```
<table>
<tr>
	<th>
    	Request
    </th>
    <th>
    	V2
    </th>
    <th>
    	V1
    </th>
</tr>
<tr>
	<td>
    	Create
    </td>
    <td>
    	var category = await client
        							.WithApi()
                                    .WithProjectKey("project-key")
                                    .Categories()
                                    .Post(categoryDraft)
                                    .ExecuteAsync();
    </td>
    <td>
    var category = await client
                                .Builder()
                                .Categories()
                                .Create(categoryDraft)
                                .ExecuteAsync();
    </td>
</tr>
<tr>
	<td>
    	Get By Id
    </td>
    <td>
    	var queriedCategory = await client.WithApi().WithProjectKey("project-key")
                        .Categories()
                        .WithId(category.Id)
                        .Get()
                        .ExecuteAsync();
    </td>
    <td>
     var queriedCategory = await client
                            .Builder()
                            .Categories()
                            .GetById(category.Id)
                            .ExecuteAsync();
    </td>
</tr>
<tr>
	<td>
    	Get By Key
    </td>
    <td>
    	var queriedCategory = await client.WithApi().WithProjectKey("project-key")
                        .Categories()
                        .WithKey(category.Key)
                        .Get()
                        .ExecuteAsync();
    </td>
    <td>
     var queriedCategory = await client
                            .Builder()
                            .Categories()
                            .GetByKey(category.Key)
                            .ExecuteAsync();
    </td>
</tr>
<tr>
	<td>
    	Query
    </td>
    <td>
    	var response = await client.WithApi().WithProjectKey("project-key")
                    .Categories()
                    .Get()
                    .WithWhere($"key = \"{category.Key}\"")
                    .ExecuteAsync();
    </td>
    <td>
     var response = await client
                             .Builder()
                             .Categories()
                             .Query()
                             .Where(c => c.Key == category.Key.valueOf())
                             .ExecuteAsync();
    </td>
</tr>
<tr>
	<td>
    	Delete By Id
    </td>
    <td>
    	var deletedCategory = await client.WithApi().WithProjectKey("project-key")
                    .Categories()
                    .WithId(category.Id)
                    .Delete()
                    .WithVersion(category.version)
                    .ExecuteAsync();
    </td>
    <td>
    var category = await client
                                 .Builder()
                                 .Categories()
                                 .DeleteById(category)
                                 .ExecuteAsync();
    </td>
</tr>
<tr>
	<td>
    	Delete By Key
    </td>
    <td>
    	var deletedCategory = await client.WithApi().WithProjectKey("project-key")
                    .Categories()
                    .WithKey(category.Key)
                    .Delete()
                    .WithVersion(category.version)
                    .ExecuteAsync();
    </td>
    <td>
    var category = await client
                                 .Builder()
                                 .Categories()
                                 .DeleteByKey(category.Key, category.Version)
                                 .ExecuteAsync();
    </td>
</tr>
<tr>
	<td>
    	Update
    </td>
    <td>
    	var updatedCategory = await client.WithApi().WithProjectKey("project-key")
                    .Categories()
                    .WithId(category.Id)
                    .Post(categoryUpdate)
                    .ExecuteAsync();
    </td>
    <td>
    var updatedCategory = await client
                        .Builder()
                        .Categories()
                        .UpdateById(category)
                        .AddAction(action)
                        .ExecuteAsync();
    </td>
</tr>
</table>