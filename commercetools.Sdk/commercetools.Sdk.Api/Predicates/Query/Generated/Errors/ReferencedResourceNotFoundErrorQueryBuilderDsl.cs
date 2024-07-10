using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ReferencedResourceNotFoundErrorQueryBuilderDsl
    {
        public ReferencedResourceNotFoundErrorQueryBuilderDsl()
        {
        }

        public static ReferencedResourceNotFoundErrorQueryBuilderDsl Of()
        {
            return new ReferencedResourceNotFoundErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReferencedResourceNotFoundErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ReferencedResourceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ReferencedResourceNotFoundErrorQueryBuilderDsl>(p, ReferencedResourceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReferencedResourceNotFoundErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ReferencedResourceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ReferencedResourceNotFoundErrorQueryBuilderDsl>(p, ReferencedResourceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReferencedResourceNotFoundErrorQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ReferencedResourceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ReferencedResourceNotFoundErrorQueryBuilderDsl>(p, ReferencedResourceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReferencedResourceNotFoundErrorQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ReferencedResourceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ReferencedResourceNotFoundErrorQueryBuilderDsl>(p, ReferencedResourceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReferencedResourceNotFoundErrorQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ReferencedResourceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ReferencedResourceNotFoundErrorQueryBuilderDsl>(p, ReferencedResourceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
