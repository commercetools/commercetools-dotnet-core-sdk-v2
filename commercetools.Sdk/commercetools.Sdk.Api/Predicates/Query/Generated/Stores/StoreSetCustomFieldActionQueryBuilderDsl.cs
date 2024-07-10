// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetCustomFieldActionQueryBuilderDsl
    {
        public StoreSetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static StoreSetCustomFieldActionQueryBuilderDsl Of()
        {
            return new StoreSetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetCustomFieldActionQueryBuilderDsl>(p, StoreSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<StoreSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<StoreSetCustomFieldActionQueryBuilderDsl>(p, StoreSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<StoreSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<StoreSetCustomFieldActionQueryBuilderDsl>(p, StoreSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
