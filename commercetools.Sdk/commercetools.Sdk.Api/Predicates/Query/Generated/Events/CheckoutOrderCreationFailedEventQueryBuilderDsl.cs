using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class CheckoutOrderCreationFailedEventQueryBuilderDsl
    {
        public CheckoutOrderCreationFailedEventQueryBuilderDsl()
        {
        }

        public static CheckoutOrderCreationFailedEventQueryBuilderDsl Of()
        {
            return new CheckoutOrderCreationFailedEventQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CheckoutOrderCreationFailedEventQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CheckoutOrderCreationFailedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CheckoutOrderCreationFailedEventQueryBuilderDsl>(p, CheckoutOrderCreationFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutOrderCreationFailedEventQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<CheckoutOrderCreationFailedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<CheckoutOrderCreationFailedEventQueryBuilderDsl>(p, CheckoutOrderCreationFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutOrderCreationFailedEventQueryBuilderDsl, string> ResourceType()
        {
            return new ComparisonPredicateBuilder<CheckoutOrderCreationFailedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceType")),
            p => new CombinationQueryPredicate<CheckoutOrderCreationFailedEventQueryBuilderDsl>(p, CheckoutOrderCreationFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutOrderCreationFailedEventQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CheckoutOrderCreationFailedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CheckoutOrderCreationFailedEventQueryBuilderDsl>(p, CheckoutOrderCreationFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutOrderCreationFailedEventQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CheckoutOrderCreationFailedEventQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CheckoutOrderCreationFailedEventQueryBuilderDsl>(p, CheckoutOrderCreationFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CheckoutOrderCreationFailedEventQueryBuilderDsl> Data(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CheckoutOrderCreationFailedEventQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("data"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl.Of())),
                CheckoutOrderCreationFailedEventQueryBuilderDsl.Of);
        }


    }
}
