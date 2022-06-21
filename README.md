# Composable Commerce .NET SDK

## Introduction

This repository contains the .NET SDKs generated from the Composable Commerce API reference. 

## Packages

| Package | Version|
| --------| --------------------------------------------------------------------------------------------------------- |
| HTTP API | [![NuGet Version and Downloads count](https://buildstats.info/nuget/commercetools.Sdk.Api?includePreReleases=true)](https://www.nuget.org/packages/commercetools.Sdk.Api)|
| Import API | [![NuGet Version and Downloads count](https://buildstats.info/nuget/commercetools.Sdk.ImportApi?includePreReleases=true)](https://www.nuget.org/packages/commercetools.Sdk.ImportApi)|
| ML API | [![NuGet Version and Downloads count](https://buildstats.info/nuget/commercetools.Sdk.MLApi?includePreReleases=true)](https://www.nuget.org/packages/commercetools.Sdk.MLApi)|
| Change History API | [![NuGet Version and Downloads count](https://buildstats.info/nuget/commercetools.Sdk.HistoryApi?includePreReleases=true)](https://www.nuget.org/packages/commercetools.Sdk.HistoryApi)|

## Example and Training material
Feel free to explore these examples using this SDK for calling Composable Commerce, and Import API.
[.NET Core SDK Training for V2 SDK](https://github.com/commercetools/commercetools-dotnet-sdk-training/tree/Training-SDKV2)

## Installation
#### Download from [Nuget](https://www.nuget.org/profiles/commercetools)
| Package                                                                         | Installation                                                                                                                                  |
| ------------------------------------------------------------------------------- | ----------------------------------------------------------|
| [HTTP API](https://www.nuget.org/packages/commercetools.Sdk.Api) | ```dotnet add package commercetools.Sdk.Api```            |
| [Import API](https://www.nuget.org/packages/commercetools.Sdk.ImportApi)        | ```dotnet add package commercetools.Sdk.ImportApi```      |
| [ML API](https://www.nuget.org/packages/commercetools.Sdk.MLApi)                | ```dotnet add package commercetools.Sdk.MLApi```          |
| [Change History API](https://www.nuget.org/packages/commercetools.Sdk.HistoryApi)      | ```dotnet add package commercetools.Sdk.HistoryApi```     |

## Technical Overview

The SDK consists of the following projects:
* `commercetools.Base.Abstractions`: Contains common classes and interfaces that can be used in other SDK projects like IClient and ISerializerService.
* `commercetools.Base.Client`: Contains CtpClient which communicate with Composable Commerce to execute requests, it contains also the classes related to the client like tokens,middlewares and handlers.
* `commercetools.Base.Registration`: Helper classes for things like types retriever.
* `commercetools.Base.Serialization`: Serialization and deserialization services for responses and requests to the HTTP API using System.Text.Json.
* `commercetools.SDK.Api`: Contains all generated models and request builders to communicate with [Composable Commerce HTTP API](https://docs.commercetools.com/http-api.html).
* `commercetools.SDK.ImportApi`: Contains all generated models and request builders to communicate with the [Import API](https://docs.commercetools.com/import-api/).
* `commercetools.SDK.MLApi`: Contains all generated models and request builders to communicate with the [Machine Learning API](https://docs.commercetools.com/api/ml).
* `commercetools.SDK.HistoryApi`: Contains all generated models and request builders to communicate with the history api.

In addition, the SDK has the following directories:
* `/IntegrationTests`: Integration tests for the SDK. A good way for anyone using the .NET SDK to understand it further.
* `/Tests`: Unit Tests for serialization and request builders.
* `/Examples`:
  1. `commercetools.Api.ConsoleApp` as an example of how to use the SDK in a console app and create a client using ClientFactory.
  2. `commercetools.Api.CheckoutApp`, [the example](https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/tree/master/commercetools.Sdk/Examples/commercetools.Api.CheckoutApp) is developed
     to illustrate how to deal with the me endpoints, like listing and adding products
     to cart as anonymous user, user can login and switch to password token flow,
     it's storing the token in the cookie right now, cookies only used
     as POC, it maybe not the best option for production purposes.

## Getting Started with the .NET SDK

All operations (get, query, create, update, delete and others) are available in the generated request builders, so you can build the request and use the client to execute it and all the request builders accessible through ApiRoot.
In order to use the client object, it needs to be setup first through dependency injection setup.

### Basic Workflow

At a high level, to make a basic call to the API, do the following:

1. Use the dependency injection class to set things up.
2. get a client object from the services responsible for calling requests to the API
3. use the ApiRoot instance inside the client and identify the project-key.
4. If needed – Create a draft object as a required for the request based on the documentation.
5. Build your request and execute it using ExecuteAsync.
6. Receive the response as a model.

#### Dependency Injection Setup

 In the ConfigureServices method of Startup.cs add the following:

* `Composable Commerce API`:
```c#
services.UseCommercetoolsApi(this.configuration, "Client"); // replace with your instance of IConfiguration
```
* `Import API`:
```c#
services.UseCommercetoolsImportApi(this.configuration, "ImportClient");
```
* `ML API`:
```c#
services.UseCommercetoolsMLApi(this.configuration, "MLClient");
```
* `History API`:
```c#
services.UseCommercetoolsHistoryApi(this.configuration, "HistoryClient");
```

##### Configuration
The client configuration needs to be added to appsettings.json in order for the client to work. The structure is as follows:

```c#
{
    "Client": {
        "ClientId": "", // replace with your client ID
        "ClientSecret": "", // replace with your client secret
        "AuthorizationBaseAddress": "https://auth.europe-west1.gcp.commercetools.com/", // replace if needed
        "Scope": "", // replace with your scope
        "ProjectKey": "", // replace with your project key
        "ApiBaseAddress": "https://api.europe-west1.gcp.commercetools.com/"  // replace if needed
    }
}
```

##### Getting instance of ApiRoot
you can use the instance inside the injected client or use ApiFactory to create a new instance.
* `Composable Commerce API`:
```c#
var root1 = client.WithApi();
var root2 = ApiFactory.Create(client);
```
* `Import API`:
```c#
var root1 = client.WithImportApi();
var root2 = ImportApiFactory.Create(client);
```
* `Machine Learning API`:
```c#
var root1 = client.WithMLApi();
var root2 = MLApiFactory.Create(client);
```
* `Change History API`:
```c#
var root1 = client.WithHistoryApi();
var root2 = HistoryApiFactory.Create(client);
```

### Multiple Clients
It is possible to use more than one client in the same application with different token providers.
The following code can be used to set it up 2 clients with the default ClientCredentials token provider:

```c#
services.UseCommercetoolsApi(configuration,
                new List<string>{"AdminClient", "StoreClient"},
                CreateTokenProvider);

public static ITokenProvider CreateTokenProvider(string clientName, IConfiguration configuration, IServiceProvider serviceProvider)
        {
            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            var clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
            return TokenProviderFactory.CreateClientCredentialsTokenProvider(clientConfiguration, httpClientFactory);
        }
```

you can choose different token provider based on the clientName, Also The appsettings.json then needs to contain the configuration sections named the same.
The clients can then be injected by using IEnumerable and specific client can be selected by name.
```c#
    public MyController(IEnumerable<IClient> clients)
    {
        var storeClient = clients.FirstOrDefault(c => c.Name.Equals("StoreClient"));
    }
```

### Using SDK

SDK follows a builder pattern when creating requests. Category resource will be used to demonstrate how to use the SDK. This behaviour is the same for all resources.
The IClient interface can be used by injecting it and calling its ExecuteAsync method for different requests.
```c#
private readonly IClient client;
public CategoryController(IClient client)
{
    this.client = client;
}
public async Task CreatingRequests()
{
    // Create CategoryDraft
    var categoryDraft = new CategoryDraft
                {
                    Name = new LocalizedString {{"en", "Name"}},
                    Slug = new LocalizedString {{"en", "Slug"}},
                    Key = "Key"
                };

    // Use in the previous step configured client instance to send and receive a newly created Category
     var category = await client.WithApi().WithProjectKey("project-key")
                                    .Categories()
                                    .Post(categoryDraft)
                                    .ExecuteAsync();

    // Get Category by id
    var queriedCategory = await client.WithApi().WithProjectKey("project-key")
                .Categories()
                .WithId(category.Id)
                .Get()
                .ExecuteAsync();

    // Get Category by key
    var queriedCategory = await client.WithApi().WithProjectKey("project-key")
                .Categories()
                .WithKey(category.Key)
                .Get()
                .ExecuteAsync();

    // Query Categories
    var response = await client.WithApi().WithProjectKey("project-key")
            .Categories()
            .Get()
            .WithWhere($"key = \"{category.Key}\"")
            .ExecuteAsync();

    // Delete Category by id
    var deletedCategory = await client.WithApi().WithProjectKey("project-key")
            .Categories()
            .WithId(category.Id)
            .Delete()
            .WithVersion(category.version)
            .ExecuteAsync();

    // Update Category
    var newName = "newName";
    var action = new CategoryChangeNameAction
                    {
                        Name = new LocalizedString {{"en", newName}}
                    };
    var update = new CategoryUpdate
                    {
                        Version = category.Version,
                        Actions = new List<ICategoryUpdateAction> {action}
                    };

    var updatedCategory = await client.WithApi().WithProjectKey("project-key")
            .Categories()
            .WithId(category.Id)
            .Post(categoryUpdate)
            .ExecuteAsync();

    // Delete Category by key
    var deletedCategory = await client.WithApi().WithProjectKey("project-key")
            .Categories()
            .WithKey(category.Key)
            .Delete()
            .WithVersion(category.Version)
            .ExecuteAsync();
    }

```
### Creating a client using ClientFactory
You can get a client from injected services or you can create client on the fly using ClientFactory,
the example below illustrate how to create a client with password TokenFlow to get customer's orders:

```c#
private readonly IServiceProvider serviceProvider;

public CustomerController(IServiceProvider serviceProvider)
{
    this.serviceProvider = serviceProvider;
}
public async Task ExecuteAsync()
{
    var email = "customerEmail";
    var password = "customerPassword";

    var configuration = serviceProvider.GetService<IConfiguration>();
    var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
    var serializerService = serviceProvider.GetService<SerializerService>();

    var clientConfiguration = configuration.GetSection("MeClient").Get<ClientConfiguration>();

    //Create passwordFlow TokenProvider
    var passwordTokenProvider = TokenProviderFactory
        .CreatePasswordTokenProvider(clientConfiguration,
            httpClientFactory,
            new InMemoryUserCredentialsStoreManager(email, password));

    //Create MeClient
    var meClient = ClientFactory.Create(
        "MeClient",
        clientConfiguration,
        httpClientFactory,
        serializerService,
        passwordTokenProvider);

    //Get Customer Profile
    var myProfile = await meClient.WithApi().WithProjectKey("project-key")
        .Me()
        .Get()
        .ExecuteAsync();

    //Get Customer Orders
    var myOrders = await
        meClient.WithApi()
            .WithProjectKey("project-key")
            .Me()
            .Orders()
            .Get()
            .ExecuteAsync();
}
```
If you are going to create the client using the ClientFactory, don't forget to call
SetupClient extension method [here](https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/blob/master/commercetools.Sdk/commercetools.Base.Client/DependencyInjectionSetup.cs#L92) while building
the services container. This will attach the Default Handlers like ErrorHandler and LoggerHandler to the Client like below:
```c#
services.SetupClient(
                "MeClient",
                errorTypeMapper => typeof(ErrorResponse),
                s => s.GetService<SerializerService>()
            );
```
### Migration Guidelines
To migrate from the 1.x to the 2.x, there is a guideline below:
* [Migration guidelines from v1 to v2](COMPARISON.md)
