using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.VariantAttributes
{

    public partial class VariantAttributesAvailabilityQueryBuilderDsl
    {
        public VariantAttributesAvailabilityQueryBuilderDsl()
        {
        }

        public static VariantAttributesAvailabilityQueryBuilderDsl Of()
        {
            return new VariantAttributesAvailabilityQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantAttributesAvailabilityQueryBuilderDsl, bool> IsOnStock()
        {
            return new ComparisonPredicateBuilder<VariantAttributesAvailabilityQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isOnStock")),
            p => new CombinationQueryPredicate<VariantAttributesAvailabilityQueryBuilderDsl>(p, VariantAttributesAvailabilityQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantAttributesAvailabilityQueryBuilderDsl, long> AvailableQuantity()
        {
            return new ComparisonPredicateBuilder<VariantAttributesAvailabilityQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("availableQuantity")),
            p => new CombinationQueryPredicate<VariantAttributesAvailabilityQueryBuilderDsl>(p, VariantAttributesAvailabilityQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantAttributesAvailabilityQueryBuilderDsl> Channels(
            Func<commercetools.Sdk.Api.Predicates.Query.VariantAttributes.VariantAttributesChannelAvailabilityMapQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.VariantAttributes.VariantAttributesChannelAvailabilityMapQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantAttributesAvailabilityQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.VariantAttributes.VariantAttributesChannelAvailabilityMapQueryBuilderDsl.Of())),
                VariantAttributesAvailabilityQueryBuilderDsl.Of);
        }


    }
}
