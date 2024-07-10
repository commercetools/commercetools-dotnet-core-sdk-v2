// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reviews
{

    public partial class ReviewResourceIdentifierQueryBuilderDsl
    {
        public ReviewResourceIdentifierQueryBuilderDsl()
        {
        }

        public static ReviewResourceIdentifierQueryBuilderDsl Of()
        {
            return new ReviewResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ReviewResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ReviewResourceIdentifierQueryBuilderDsl>(p, ReviewResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ReviewResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ReviewResourceIdentifierQueryBuilderDsl>(p, ReviewResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ReviewResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ReviewResourceIdentifierQueryBuilderDsl>(p, ReviewResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
