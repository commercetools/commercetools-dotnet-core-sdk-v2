// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class DiscountsConfigurationQueryBuilderDsl
    {
        public DiscountsConfigurationQueryBuilderDsl()
        {
        }

        public static DiscountsConfigurationQueryBuilderDsl Of()
        {
            return new DiscountsConfigurationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountsConfigurationQueryBuilderDsl, string> DiscountCombinationMode()
        {
            return new ComparisonPredicateBuilder<DiscountsConfigurationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountCombinationMode")),
            p => new CombinationQueryPredicate<DiscountsConfigurationQueryBuilderDsl>(p, DiscountsConfigurationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
