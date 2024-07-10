// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class BadGatewayErrorQueryBuilderDsl
    {
        public BadGatewayErrorQueryBuilderDsl()
        {
        }

        public static BadGatewayErrorQueryBuilderDsl Of()
        {
            return new BadGatewayErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BadGatewayErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<BadGatewayErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<BadGatewayErrorQueryBuilderDsl>(p, BadGatewayErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BadGatewayErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<BadGatewayErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<BadGatewayErrorQueryBuilderDsl>(p, BadGatewayErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
