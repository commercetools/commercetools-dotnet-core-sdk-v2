// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Zones
{

    public partial class ZoneSetKeyActionQueryBuilderDsl
    {
        public ZoneSetKeyActionQueryBuilderDsl()
        {
        }

        public static ZoneSetKeyActionQueryBuilderDsl Of()
        {
            return new ZoneSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ZoneSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ZoneSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ZoneSetKeyActionQueryBuilderDsl>(p, ZoneSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ZoneSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ZoneSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ZoneSetKeyActionQueryBuilderDsl>(p, ZoneSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
