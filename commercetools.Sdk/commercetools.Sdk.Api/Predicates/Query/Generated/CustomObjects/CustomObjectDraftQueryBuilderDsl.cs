using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomObjects
{

    public partial class CustomObjectDraftQueryBuilderDsl
    {
        public CustomObjectDraftQueryBuilderDsl()
        {
        }

        public static CustomObjectDraftQueryBuilderDsl Of()
        {
            return new CustomObjectDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomObjectDraftQueryBuilderDsl, string> Container()
        {
            return new ComparisonPredicateBuilder<CustomObjectDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("container")),
            p => new CombinationQueryPredicate<CustomObjectDraftQueryBuilderDsl>(p, CustomObjectDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomObjectDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CustomObjectDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CustomObjectDraftQueryBuilderDsl>(p, CustomObjectDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomObjectDraftQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CustomObjectDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CustomObjectDraftQueryBuilderDsl>(p, CustomObjectDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomObjectDraftQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomObjectDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomObjectDraftQueryBuilderDsl>(p, CustomObjectDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
