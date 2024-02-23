# ME Endpoint Checkout App

This example application demonstrates how the ME endpoints can be used with the DotNET v2 SDK.

## Requirements

- A Composable Commerce Project with a configured [API Client](https://docs.commercetools.com/getting-started/create-api-client#create-an-api-client).
  - Your API Client must have the following scopes: `view_published_products`, `view_categories`, `manage_my_profile`, `manage_my_shopping_lists`, `manage_my_payments`, `manage_my_orders`
- Your Project must have existing Products containing Variants with SKUs, and at least one Customer.
  - If your Project is currently empty, you can install the [SUNRISE sample data](https://github.com/commercetools/commercetools-sunrise-data).

## Installation

1. Clone/Download the Examples folder.
2. Open **\Examples\commercetools.Api.CheckoutApp\appsettings.json** and replace the placeholder values with your API Client credentials.

![image](https://user-images.githubusercontent.com/77231096/180888862-2e911f43-db94-4ae1-b2bc-479ae7e549e2.png)

## Using the ME Endpoint Checkout App

### In Visual Studio

1. Open **\Examples\commercetools.Api.CheckoutApp\commercetools.Api.CheckoutApp.csproj**
2. Select **commercetools.Api.CheckoutApp**

![checkoutapp](https://user-images.githubusercontent.com/77231096/180888672-8045a167-6fc4-4fdb-8b11-2ea1bac10319.png)

3. Start the app using **Debug** > **Start Debugging** or by pressing **F5**.
4. A new web browser window opens and displays the Checkout app. A list of Products should appear.

### In Visual Studio Code

1. Open the folder **\Examples\commercetools.Api.CheckoutApp**
2. Start the app using **Run** > **Start Debugging** or by pressing **F5**.
3. A new web browser window opens and displays the Checkout app. A list of Products should appear.

## OpenTelemetry

For experimenting with OpenTelemetry the example Checkout application is configured for exporting logs, metrics and traces
using OpenTelemetry. By default the data will be reported to the console.

To send the data to an OpenTelemetry endpoint you have to configure the
[appsettings.json](https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/blob/master/commercetools.Sdk/Examples/commercetools.Api.CheckoutApp/appsettings.json) file.

```json
{
  "UseLogExporter": "otlp",
  "UseTracingExporter": "otlp",
  "UseMetricExporter": "otlp"
}
```

Setting the exporter options to `otlp` will send the data to a local OTLP endpoint at `http://localhost:4317`. Please
make sure to have a OpenTelemetry collector listening. You can override the endpoint address by configuring
`Otlp:Endpoint` in your appsettings.json file.

The [OpenTelemetry collector example](https://github.com/commercetools/opentelemetry-collector-example) repository includes a docker compose setup for starting a local OpenTelemetry
collector in combination with Prometheus, Grafana, JaegerUI and NewRelic as exporter target.


