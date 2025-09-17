using System.Collections.Generic;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.CheckoutApi;
using commercetools.Sdk.CheckoutApi.Models.Applications;
using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;
using commercetools.Sdk.CheckoutApi.Models.Transactions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using CartResourceIdentifier = commercetools.Sdk.CheckoutApi.Models.Carts.CartResourceIdentifier;
using CheckoutApiRoot = commercetools.Sdk.CheckoutApi.Client.ProjectApiRoot;
using ProjectApiRoot = commercetools.Sdk.Api.Client.ProjectApiRoot;

namespace commercetools.Api.IntegrationTests.Checkout;

public class CheckoutIntegrationTests
{
    [Fact]
    public async void api_and_checkout()
    {
        var configuration = new ConfigurationBuilder().
            AddJsonFile("appsettings.test.Development.json", true).
            AddEnvironmentVariables().
            AddUserSecrets<ServiceProviderFixture>().
            AddEnvironmentVariables("CTP_").
            Build();

        var s = new ServiceCollection();
        s.UseCommercetoolsCheckoutApi(configuration, "Checkout");
        s.UseCommercetoolsApi(configuration, "Client");
        var p = s.BuildServiceProvider();

        var apiConfig = configuration.GetSection("Client").Get<ClientConfiguration>();
        var checkoutApiRoot = p.GetService<CheckoutApiRoot>();
        var apiRoot = p.GetService<ProjectApiRoot>();

        Assert.Equal("Checkout", checkoutApiRoot.ClientName);
        Assert.Equal("Client", apiRoot.ClientName);
        var project = await apiRoot.Get().ExecuteAsync().ConfigureAwait(false);

        Assert.Equal(apiConfig.ProjectKey, project.Key);

        var newCart = new CartDraft()
        {
            Currency = "EUR"
        };

        var cart = await apiRoot.Carts().Post(newCart).ExecuteAsync().ConfigureAwait(false);
        Assert.NotNull(cart);

        Thread.Sleep(500);
        var transactionKey = "transaction-" + TestingUtility.RandomString();
        var transaction = await checkoutApiRoot.Transactions()

            .Post(new TransactionDraft()
            {
                Key = transactionKey,
                Application = new ApplicationResourceIdentifier()
                {
                    Key = "demo-commercetools-checkout"
                },
                Cart = new CartResourceIdentifier()
                {
                    Id = cart.Id
                },
                TransactionItems = new List<ITransactionItemDraft>()
                {
                    new TransactionItemDraft()
                    {
                        Amount = new Amount() { CentAmount = 100, CurrencyCode = "EUR" },
                        PaymentIntegration = new PaymentIntegrationResourceIdentifier()
                            { Key = "ci-payment-integration" }
                    }
                }
            }).ExecuteAsync().ConfigureAwait(false);

        // Create transaction
        Assert.NotNull(transaction);

        Assert.NotNull(
            await checkoutApiRoot.Transactions().WithId(transaction.Id).Get().ExecuteAsync().ConfigureAwait(false));
        Assert.Equal(transactionKey, transaction.Key);
        Assert.NotNull(
            await checkoutApiRoot.Transactions().WithKey(transaction.Key).Get().ExecuteAsync().ConfigureAwait(false));
    }
}