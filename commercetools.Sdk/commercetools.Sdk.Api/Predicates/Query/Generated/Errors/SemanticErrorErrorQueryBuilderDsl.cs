// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class SemanticErrorErrorQueryBuilderDsl
    {
        public SemanticErrorErrorQueryBuilderDsl()
        {
        }

        public static SemanticErrorErrorQueryBuilderDsl Of()
        {
            return new SemanticErrorErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SemanticErrorErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<SemanticErrorErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<SemanticErrorErrorQueryBuilderDsl>(p, SemanticErrorErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SemanticErrorErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<SemanticErrorErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<SemanticErrorErrorQueryBuilderDsl>(p, SemanticErrorErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
