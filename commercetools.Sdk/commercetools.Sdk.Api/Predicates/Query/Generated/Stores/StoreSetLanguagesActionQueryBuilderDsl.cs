// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetLanguagesActionQueryBuilderDsl
    {
        public StoreSetLanguagesActionQueryBuilderDsl()
        {
        }

        public static StoreSetLanguagesActionQueryBuilderDsl Of()
        {
            return new StoreSetLanguagesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetLanguagesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetLanguagesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetLanguagesActionQueryBuilderDsl>(p, StoreSetLanguagesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<StoreSetLanguagesActionQueryBuilderDsl, string> Languages()
        {
            return new ComparableCollectionPredicateBuilder<StoreSetLanguagesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("languages")),
            p => new CombinationQueryPredicate<StoreSetLanguagesActionQueryBuilderDsl>(p, StoreSetLanguagesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
