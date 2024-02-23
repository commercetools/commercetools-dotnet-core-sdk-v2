using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomObjects
{

    public partial class CustomObjectQueryBuilderDsl
    {
        public CustomObjectQueryBuilderDsl()
        {
        }

        public static CustomObjectQueryBuilderDsl Of()
        {
            return new CustomObjectQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomObjectQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomObjectQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomObjectQueryBuilderDsl>(p, CustomObjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomObjectQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomObjectQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomObjectQueryBuilderDsl>(p, CustomObjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomObjectQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CustomObjectQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CustomObjectQueryBuilderDsl>(p, CustomObjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomObjectQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CustomObjectQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CustomObjectQueryBuilderDsl>(p, CustomObjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomObjectQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomObjectQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CustomObjectQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomObjectQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomObjectQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CustomObjectQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomObjectQueryBuilderDsl, string> Container()
        {
            return new ComparisonPredicateBuilder<CustomObjectQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("container")),
            p => new CombinationQueryPredicate<CustomObjectQueryBuilderDsl>(p, CustomObjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomObjectQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CustomObjectQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CustomObjectQueryBuilderDsl>(p, CustomObjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomObjectQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CustomObjectQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CustomObjectQueryBuilderDsl>(p, CustomObjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
