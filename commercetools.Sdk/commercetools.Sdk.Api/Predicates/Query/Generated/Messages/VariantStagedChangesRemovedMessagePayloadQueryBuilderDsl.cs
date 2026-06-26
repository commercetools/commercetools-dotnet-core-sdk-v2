// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl
    {
        public VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl>(p, VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
