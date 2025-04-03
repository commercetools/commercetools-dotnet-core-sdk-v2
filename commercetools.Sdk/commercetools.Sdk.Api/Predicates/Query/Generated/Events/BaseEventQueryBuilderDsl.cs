using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class BaseEventQueryBuilderDsl
    {
        public BaseEventQueryBuilderDsl()
        {
        }

        public static BaseEventQueryBuilderDsl Of()
        {
            return new BaseEventQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BaseEventQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<BaseEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<BaseEventQueryBuilderDsl>(p, BaseEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseEventQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<BaseEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<BaseEventQueryBuilderDsl>(p, BaseEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseEventQueryBuilderDsl, string> ResourceType()
        {
            return new ComparisonPredicateBuilder<BaseEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceType")),
            p => new CombinationQueryPredicate<BaseEventQueryBuilderDsl>(p, BaseEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseEventQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BaseEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BaseEventQueryBuilderDsl>(p, BaseEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseEventQueryBuilderDsl, string> Data()
        {
            return new ComparisonPredicateBuilder<BaseEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("data")),
            p => new CombinationQueryPredicate<BaseEventQueryBuilderDsl>(p, BaseEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseEventQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<BaseEventQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<BaseEventQueryBuilderDsl>(p, BaseEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
