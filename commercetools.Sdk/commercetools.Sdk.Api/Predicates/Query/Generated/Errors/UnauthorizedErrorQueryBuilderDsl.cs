// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class UnauthorizedErrorQueryBuilderDsl
    {
        public UnauthorizedErrorQueryBuilderDsl()
        {
        }

        public static UnauthorizedErrorQueryBuilderDsl Of()
        {
            return new UnauthorizedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<UnauthorizedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<UnauthorizedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<UnauthorizedErrorQueryBuilderDsl>(p, UnauthorizedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<UnauthorizedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<UnauthorizedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<UnauthorizedErrorQueryBuilderDsl>(p, UnauthorizedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<UnauthorizedErrorQueryBuilderDsl, string> StoresWithoutPermission()
        {
            return new ComparableCollectionPredicateBuilder<UnauthorizedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("storesWithoutPermission")),
            p => new CombinationQueryPredicate<UnauthorizedErrorQueryBuilderDsl>(p, UnauthorizedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
