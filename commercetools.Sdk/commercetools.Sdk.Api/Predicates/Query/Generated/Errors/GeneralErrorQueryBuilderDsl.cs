// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GeneralErrorQueryBuilderDsl
    {
        public GeneralErrorQueryBuilderDsl()
        {
        }

        public static GeneralErrorQueryBuilderDsl Of()
        {
            return new GeneralErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GeneralErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GeneralErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GeneralErrorQueryBuilderDsl>(p, GeneralErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GeneralErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<GeneralErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<GeneralErrorQueryBuilderDsl>(p, GeneralErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
