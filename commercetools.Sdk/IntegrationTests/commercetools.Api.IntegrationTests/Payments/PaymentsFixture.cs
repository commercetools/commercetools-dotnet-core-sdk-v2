using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using static commercetools.Api.IntegrationTests.GenericFixture;

namespace commercetools.Api.IntegrationTests.Payments
{
    public class PaymentsFixture
    {
        #region DraftBuilds
        public static PaymentDraft DefaultPaymentDraft(PaymentDraft paymentDraft)
        {
            var random = TestingUtility.RandomInt();
            paymentDraft.Key = $"Key_{random}";
            paymentDraft.AmountPlanned = Money.FromDecimal("EUR", 1000);
            return paymentDraft;
        }
        public static PaymentDraft DefaultPaymentDraftWithTransaction(PaymentDraft draft, ITransactionDraft transactionDraft)
        {
            var paymentDraft = DefaultPaymentDraft(draft);
            paymentDraft.Transactions = new List<ITransactionDraft> { transactionDraft };
            return paymentDraft;
        }

        #endregion

        #region CreateAndDelete

        public static async Task<IPayment> CreatePayment(ProjectApiRoot client, PaymentDraft paymentDraft)
        {
            var resource = await client
                .Payments()
                .Post(paymentDraft)
                .ExecuteAsync();
            return resource;
        }

        public static async Task DeletePayment(ProjectApiRoot client, IPayment payment)
        {
            try
            {
                await client
                    .Payments()
                    .WithId(payment.Id)
                    .Delete()
                    .WithVersion(payment.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #endregion

        #region WithPayment

        public static async Task WithPayment(ProjectApiRoot client, Func<PaymentDraft, PaymentDraft> draftAction, Action<IPayment> func)
        {
            await With(client, new PaymentDraft(), draftAction, func, CreatePayment, DeletePayment);
        }
        #endregion
    }
}