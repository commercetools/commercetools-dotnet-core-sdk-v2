// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class DirectDiscountReferenceQueryBuilderDsl
    {
        public DirectDiscountReferenceQueryBuilderDsl()
        {
        }

        public static DirectDiscountReferenceQueryBuilderDsl Of()
        {
            return new DirectDiscountReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DirectDiscountReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<DirectDiscountReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<DirectDiscountReferenceQueryBuilderDsl>(p, DirectDiscountReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DirectDiscountReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<DirectDiscountReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<DirectDiscountReferenceQueryBuilderDsl>(p, DirectDiscountReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
