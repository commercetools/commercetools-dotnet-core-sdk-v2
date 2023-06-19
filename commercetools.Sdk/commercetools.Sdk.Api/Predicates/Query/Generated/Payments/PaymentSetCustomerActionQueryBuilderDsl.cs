using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentSetCustomerActionQueryBuilderDsl
    {
        public PaymentSetCustomerActionQueryBuilderDsl()
        {
        }

        public static PaymentSetCustomerActionQueryBuilderDsl Of()
        {
            return new PaymentSetCustomerActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentSetCustomerActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentSetCustomerActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentSetCustomerActionQueryBuilderDsl>(p, PaymentSetCustomerActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentSetCustomerActionQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentSetCustomerActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl.Of())),
                PaymentSetCustomerActionQueryBuilderDsl.Of);
        }


    }
}
