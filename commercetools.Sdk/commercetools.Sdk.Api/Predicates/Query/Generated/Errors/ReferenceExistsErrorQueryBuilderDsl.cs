// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ReferenceExistsErrorQueryBuilderDsl
    {
        public ReferenceExistsErrorQueryBuilderDsl()
        {
        }

        public static ReferenceExistsErrorQueryBuilderDsl Of()
        {
            return new ReferenceExistsErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReferenceExistsErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ReferenceExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ReferenceExistsErrorQueryBuilderDsl>(p, ReferenceExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReferenceExistsErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ReferenceExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ReferenceExistsErrorQueryBuilderDsl>(p, ReferenceExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReferenceExistsErrorQueryBuilderDsl, string> ReferencedBy()
        {
            return new ComparisonPredicateBuilder<ReferenceExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("referencedBy")),
            p => new CombinationQueryPredicate<ReferenceExistsErrorQueryBuilderDsl>(p, ReferenceExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
