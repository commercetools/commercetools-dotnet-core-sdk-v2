// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl
    {
        public StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl, string> ReturnItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnItemId")),
            p => new CombinationQueryPredicate<StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
