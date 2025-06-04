using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class CheckoutPaymentAuthorizedEventQueryBuilderDsl
    {
        public CheckoutPaymentAuthorizedEventQueryBuilderDsl()
        {
        }

        public static CheckoutPaymentAuthorizedEventQueryBuilderDsl Of()
        {
            return new CheckoutPaymentAuthorizedEventQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CheckoutPaymentAuthorizedEventQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentAuthorizedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CheckoutPaymentAuthorizedEventQueryBuilderDsl>(p, CheckoutPaymentAuthorizedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentAuthorizedEventQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentAuthorizedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<CheckoutPaymentAuthorizedEventQueryBuilderDsl>(p, CheckoutPaymentAuthorizedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentAuthorizedEventQueryBuilderDsl, string> ResourceType()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentAuthorizedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceType")),
            p => new CombinationQueryPredicate<CheckoutPaymentAuthorizedEventQueryBuilderDsl>(p, CheckoutPaymentAuthorizedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentAuthorizedEventQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentAuthorizedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CheckoutPaymentAuthorizedEventQueryBuilderDsl>(p, CheckoutPaymentAuthorizedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentAuthorizedEventQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentAuthorizedEventQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CheckoutPaymentAuthorizedEventQueryBuilderDsl>(p, CheckoutPaymentAuthorizedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CheckoutPaymentAuthorizedEventQueryBuilderDsl> Data(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CheckoutPaymentAuthorizedEventQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("data"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl.Of())),
                CheckoutPaymentAuthorizedEventQueryBuilderDsl.Of);
        }


    }
}
