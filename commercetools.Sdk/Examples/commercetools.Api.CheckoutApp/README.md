# ME Endpoint Checkout App

This example application demonstrates how the ME endpoints can be used with the DotNET v2 SDK.

## Requirements

- A Composable Commerce Project with a configured [API Client](https://docs.commercetools.com/tutorials/getting-started#creating-an-api-client).
  - Your API Client must have the following scopes: `view_published_products`, `view_categories`, `manage_my_profile`, `manage_my_shopping_lists`, `manage_my_payments`, `manage_my_orders`
- Your Project must have existing Products containing Variants with SKUs, and at least one Customer.
  - If your Project is currently empty, you can install the [SUNRISE sample data](https://docs.commercetools.com/sdk/sunrise-data).

## Installation

1. Clone/Download the Examples folder.
2. Open **\Examples\commercetools.Api.CheckoutApp\appsettings.json** and replace the placeholder values with your API Client credentials.

![image](https://user-images.githubusercontent.com/77231096/180888862-2e911f43-db94-4ae1-b2bc-479ae7e549e2.png)

## Using the ME Endpoint Checkout App

### In Visual Studio

1. Open **\commercetools-dotnet-core-sdk-v2\commercetools.Sdk\commercetools.Sdk.sln**
2. Select **commercetools.Api.CheckoutApp**

![checkoutapp](https://user-images.githubusercontent.com/77231096/180888672-8045a167-6fc4-4fdb-8b11-2ea1bac10319.png)

3. Start the app using **Debug** > **Start Debugging** or by pressing **F5**.
4. A new web browser window opens and displays the Checkout app. A list of Products should appear.

### In Visual Studio Code

1. Open the folder **\Examples\commercetools.Api.CheckoutApp**
2. Start the app using **Run** > **Start Debugging** or by pressing **F5**.
3. A new web browser window opens and displays the Checkout app. A list of Products should appear.
