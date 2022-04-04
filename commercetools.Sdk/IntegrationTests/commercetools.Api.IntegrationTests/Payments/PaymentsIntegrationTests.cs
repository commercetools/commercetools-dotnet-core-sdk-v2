using System.Linq;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.Client;
using Xunit;
using static commercetools.Api.IntegrationTests.Payments.PaymentsFixture;

namespace commercetools.Api.IntegrationTests.Payments
{
    [Collection("Integration Tests")]
    public class PaymentsIntegrationTests
    {
        private readonly IClient _client;

        public PaymentsIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._client = serviceProviderFixture.GetService<IClient>();
        }

        [Fact]
        public async Task CreatePayment()
        {
            var amount = Money.FromDecimal("EUR", 10);
            var transactionDraft = new TransactionDraft
            {
                Amount = amount,
                Type = ITransactionType.Charge
            };
            await WithPayment(
                _client, paymentDraft => DefaultPaymentDraftWithTransaction(paymentDraft, transactionDraft),
                payment =>
                {
                    Assert.Single(payment.Transactions);
                    var transaction = payment.Transactions.FirstOrDefault();
                    Assert.NotNull(transaction);
                    Assert.Equal(ITransactionType.Charge, transaction.Type);
                    var retrievedAmount = transaction.Amount;
                    Assert.NotNull(retrievedAmount);
                    Assert.Equal(amount.CentAmount, retrievedAmount.CentAmount);
                    Assert.Equal(amount.CurrencyCode, retrievedAmount.CurrencyCode);
                    Assert.IsType<CentPrecisionMoney>(retrievedAmount);
                });
        }
    }
}