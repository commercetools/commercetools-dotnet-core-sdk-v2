# Dynatrace Example App

This example application demonstrates how the ME endpoints can be used with the DotNET v2 SDK.

## Requirements

- A Composable Commerce Project with a configured [API Client](https://docs.commercetools.com/getting-started/create-api-client#create-an-api-client).
  - Your API Client must have the following scopes: `view_published_products`, `view_categories`, `manage_my_profile`, `manage_my_shopping_lists`, `manage_my_payments`, `manage_my_orders`
- Your Project must have existing Products containing Variants with SKUs, and at least one Customer.
  - If your Project is currently empty, you can install the [SUNRISE sample data](https://github.com/commercetools/commercetools-sunrise-data).

## Installation

1. Clone/Download the Examples folder.
2. Open **\Examples\commercetools.Api.ApmExample\appsettings.json** and replace the placeholder values with your API Client credentials.

![image](https://user-images.githubusercontent.com/77231096/180888862-2e911f43-db94-4ae1-b2bc-479ae7e549e2.png)

## Using the app

### In Visual Studio

1. Open **\Examples\commercetools.Api.ApmExample\commercetools.Api.ApmExample.csproj**
2. Select **commercetools.Api.ApmExample**

![checkoutapp](https://user-images.githubusercontent.com/77231096/180888672-8045a167-6fc4-4fdb-8b11-2ea1bac10319.png)

3. Start the app using **Debug** > **Start Debugging** or by pressing **F5**.
4. A new web browser window opens and displays the Checkout app. A list of Products should appear.

### In Visual Studio Code

1. Open the folder **\Examples\commercetools.Api.ApmExample**
2. Start the app using **Run** > **Start Debugging** or by pressing **F5**.
3. A new web browser window opens and displays the Checkout app. A list of Products should appear.

## Dynatrace

### Install Dynatrace OneAgent
Follow the instructions on the [Dynatrace OneAgent page](https://docs.dynatrace.com/docs/setup-and-configuration/dynatrace-oneagent#tabgroup--technology-support--operating-systems) to install the OneAgent on your system.

#### Install Dynatrace OneAgent on Mac
Currently, it is NOT possible to install Dynatrace OneAgent on macOS. For this case a [Dockerfile](./Dockerfile) is provided.
Use this file to build the application with the OneAgent included on Docker.
1. Update ENV variables in the [Dockerfile](../../Dynatrace.Dockerfile) with your Dynatrace credentials.
1. Run `docker build -t dotnet-dynatrace-oneagent .` to build the Docker image.
1. Run `docker run -p 8080:80 dotnet-dynatrace-oneagent` to start the Docker container.


```shell
docker run --rm --port 8080:80
```

## Datadog

### Install Datadog agent
Follow the instructions on the [Datadog agent page](https://docs.datadoghq.com/agent/) to install the agent on your system.

#### Run Datadog agent with docker on MacOS
We provide a [docker compose](../../../datadog.docker-compose.yml) for running the agent inside docker on Mac with Apple Silicon.

Use this file to build the application with the agent included on Docker.
1. Update env variables in the [environment file](../../../datadog.env) with your Datadog credentials.
1. Run `docker-compose --env-file datadog.env --file datadog.docker-compose.yml up -d` to build and start the stack.

Now locate to http://localhost:8080. You should now be able to see the requests in your Datadog account