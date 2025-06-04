using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class CheckoutPaymentChargedEventQueryBuilderDsl
    {
        public CheckoutPaymentChargedEventQueryBuilderDsl()
        {
        }

        public static CheckoutPaymentChargedEventQueryBuilderDsl Of()
        {
            return new CheckoutPaymentChargedEventQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CheckoutPaymentChargedEventQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentChargedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CheckoutPaymentChargedEventQueryBuilderDsl>(p, CheckoutPaymentChargedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentChargedEventQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentChargedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<CheckoutPaymentChargedEventQueryBuilderDsl>(p, CheckoutPaymentChargedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentChargedEventQueryBuilderDsl, string> ResourceType()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentChargedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceType")),
            p => new CombinationQueryPredicate<CheckoutPaymentChargedEventQueryBuilderDsl>(p, CheckoutPaymentChargedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentChargedEventQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentChargedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CheckoutPaymentChargedEventQueryBuilderDsl>(p, CheckoutPaymentChargedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentChargedEventQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentChargedEventQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CheckoutPaymentChargedEventQueryBuilderDsl>(p, CheckoutPaymentChargedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CheckoutPaymentChargedEventQueryBuilderDsl> Data(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CheckoutPaymentChargedEventQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("data"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl.Of())),
                CheckoutPaymentChargedEventQueryBuilderDsl.Of);
        }


    }
}
