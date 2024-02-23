// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class PlatformFormatQueryBuilderDsl
    {
        public PlatformFormatQueryBuilderDsl()
        {
        }

        public static PlatformFormatQueryBuilderDsl Of()
        {
            return new PlatformFormatQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PlatformFormatQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PlatformFormatQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PlatformFormatQueryBuilderDsl>(p, PlatformFormatQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
