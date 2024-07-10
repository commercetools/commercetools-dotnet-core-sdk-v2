// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetParcelCustomFieldActionQueryBuilderDsl
    {
        public StagedOrderSetParcelCustomFieldActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetParcelCustomFieldActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetParcelCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetParcelCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetParcelCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetParcelCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetParcelCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetParcelCustomFieldActionQueryBuilderDsl, string> ParcelId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetParcelCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelId")),
            p => new CombinationQueryPredicate<StagedOrderSetParcelCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetParcelCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetParcelCustomFieldActionQueryBuilderDsl, string> ParcelKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetParcelCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelKey")),
            p => new CombinationQueryPredicate<StagedOrderSetParcelCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetParcelCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetParcelCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetParcelCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<StagedOrderSetParcelCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetParcelCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetParcelCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetParcelCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<StagedOrderSetParcelCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetParcelCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
