// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class AzureFunctionsAuthenticationQueryBuilderDsl
    {
        public AzureFunctionsAuthenticationQueryBuilderDsl()
        {
        }

        public static AzureFunctionsAuthenticationQueryBuilderDsl Of()
        {
            return new AzureFunctionsAuthenticationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AzureFunctionsAuthenticationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AzureFunctionsAuthenticationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AzureFunctionsAuthenticationQueryBuilderDsl>(p, AzureFunctionsAuthenticationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AzureFunctionsAuthenticationQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AzureFunctionsAuthenticationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AzureFunctionsAuthenticationQueryBuilderDsl>(p, AzureFunctionsAuthenticationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
