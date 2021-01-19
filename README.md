# commercetools .NET SDK

## Introduction

This repository contains the commercetools platform C# SDK generated from our api reference. The SDK enables developers to communicate with the [commercetools HTTP API](https://docs.commercetools.com/http-api.html). The developers do not need to create plain HTTP requests, but they can instead use the domain specific classes and methods to formulate valid requests.

## Technical Overview

The SDK consists of the following projects:
* `commercetools.Base.Abstractions`: Contains common classes and interfaces that can be used in other SDK projects like IClient and ISerializerService.
* `commercetools.Base.Client`: Contains CtpClient which communicate with the platform to execute requests, it contains also the classes related to the client like tokens,middlewares and handlers.
* `commercetools.Base.Registration`: Helper classes for things like types retriever.
* `commercetools.Base.Serialization`: Serialization and deserialization services for responses and requests to the HTTP API using System.Text.Json.
* `commercetools.SDK.Api`: Contains all generated models and request builders to communicate with the platform api.

In addition, the SDK has the following directories:
* `/IntegrationTests`: Integration tests for the SDK. A good way for anyone using the .NET SDK to understand it further.
* `/Tests`: Unit Tests for serialization and request builders.


## Getting Started with the .NET SDK

All operations (get, query, create, update, delete and others) are available in the generated request builders, so you can build the request and use the client to execute it. all the request builders accessible through ApiRoot, you can use the instance inside the injected client using function client.WithApi() or use ApiFactory to create a new instance, In order to use the client object, it needs to be setup first through dependency injection setup.

### Basic Workflow

At a high level, to make a basic call to the API, do the following:

1. Use the dependency injection class to set things up.
2. get a client object from the services responsible for calling requests to the API
3. use the ApiRoot instance inside the client and identify the project-key.
4. If needed – Create a draft object as a required for the request based on the documentation.
5. Build your request and execute it using ExecuteAsync.
6. Receive the response as a model.

### Dependency Injection Setup

 In the ConfigureServices method of Startup.cs add the following:

```c#
services.UseCommercetoolsApi(
    this.configuration); // replace with your instance of IConfiguration
```
### Configuration
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

## Using SDK

SDK follows a builder pattern when creating requests. Category resource will be used to demonstrate how to use the SDK. This behaviour is the same for all resources.
The IClient interface can be used by injecting it and calling its ExecuteAsync method for different requests.
```c#
private readonly IClient client;
public CategoryController(IClient client)
{
    this.client = client;
}
public void CreatingRequests() 
{
    // Create CategoryDraft using builder pattern
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