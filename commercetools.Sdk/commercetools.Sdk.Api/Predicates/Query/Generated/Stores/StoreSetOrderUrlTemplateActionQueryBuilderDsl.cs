// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetOrderUrlTemplateActionQueryBuilderDsl
    {
        public StoreSetOrderUrlTemplateActionQueryBuilderDsl()
        {
        }

        public static StoreSetOrderUrlTemplateActionQueryBuilderDsl Of()
        {
            return new StoreSetOrderUrlTemplateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetOrderUrlTemplateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetOrderUrlTemplateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetOrderUrlTemplateActionQueryBuilderDsl>(p, StoreSetOrderUrlTemplateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSetOrderUrlTemplateActionQueryBuilderDsl, string> OrderUrlTemplate()
        {
            return new ComparisonPredicateBuilder<StoreSetOrderUrlTemplateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderUrlTemplate")),
            p => new CombinationQueryPredicate<StoreSetOrderUrlTemplateActionQueryBuilderDsl>(p, StoreSetOrderUrlTemplateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
