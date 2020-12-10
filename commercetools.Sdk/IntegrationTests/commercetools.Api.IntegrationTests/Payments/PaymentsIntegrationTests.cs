using System.Linq;
using System.Threading.Tasks;
using commercetools.Api.Models;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using commercetools.Base.Client;
using Xunit;
using static commercetools.Api.IntegrationTests.Payments.PaymentsFixture;

namespace commercetools.Api.IntegrationTests.Payments
{
    [Collection("Integration Tests")]
    public class PaymentsIntegrationTests
    {
        private readonly IClient client;
        private readonly ServiceProviderFixture serviceProviderFixture;

        public PaymentsIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this.serviceProviderFixture = serviceProviderFixture;
            this.client = serviceProviderFixture.GetService<IClient>();
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
                client, paymentDraft => DefaultPaymentDraftWithTransaction(paymentDraft, transactionDraft),
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