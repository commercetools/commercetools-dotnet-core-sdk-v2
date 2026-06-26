// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.VariantAttributes
{

    public partial class VariantAttributesChannelAvailabilityQueryBuilderDsl
    {
        public VariantAttributesChannelAvailabilityQueryBuilderDsl()
        {
        }

        public static VariantAttributesChannelAvailabilityQueryBuilderDsl Of()
        {
            return new VariantAttributesChannelAvailabilityQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantAttributesChannelAvailabilityQueryBuilderDsl, bool> IsOnStock()
        {
            return new ComparisonPredicateBuilder<VariantAttributesChannelAvailabilityQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isOnStock")),
            p => new CombinationQueryPredicate<VariantAttributesChannelAvailabilityQueryBuilderDsl>(p, VariantAttributesChannelAvailabilityQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantAttributesChannelAvailabilityQueryBuilderDsl, long> AvailableQuantity()
        {
            return new ComparisonPredicateBuilder<VariantAttributesChannelAvailabilityQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("availableQuantity")),
            p => new CombinationQueryPredicate<VariantAttributesChannelAvailabilityQueryBuilderDsl>(p, VariantAttributesChannelAvailabilityQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
