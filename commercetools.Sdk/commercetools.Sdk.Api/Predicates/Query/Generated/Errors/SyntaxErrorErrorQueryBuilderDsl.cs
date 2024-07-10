// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class SyntaxErrorErrorQueryBuilderDsl
    {
        public SyntaxErrorErrorQueryBuilderDsl()
        {
        }

        public static SyntaxErrorErrorQueryBuilderDsl Of()
        {
            return new SyntaxErrorErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SyntaxErrorErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<SyntaxErrorErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<SyntaxErrorErrorQueryBuilderDsl>(p, SyntaxErrorErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SyntaxErrorErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<SyntaxErrorErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<SyntaxErrorErrorQueryBuilderDsl>(p, SyntaxErrorErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
