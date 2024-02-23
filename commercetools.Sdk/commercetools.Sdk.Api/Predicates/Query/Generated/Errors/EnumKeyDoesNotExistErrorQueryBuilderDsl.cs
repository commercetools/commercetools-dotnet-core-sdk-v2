// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class EnumKeyDoesNotExistErrorQueryBuilderDsl
    {
        public EnumKeyDoesNotExistErrorQueryBuilderDsl()
        {
        }

        public static EnumKeyDoesNotExistErrorQueryBuilderDsl Of()
        {
            return new EnumKeyDoesNotExistErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<EnumKeyDoesNotExistErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<EnumKeyDoesNotExistErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<EnumKeyDoesNotExistErrorQueryBuilderDsl>(p, EnumKeyDoesNotExistErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EnumKeyDoesNotExistErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<EnumKeyDoesNotExistErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<EnumKeyDoesNotExistErrorQueryBuilderDsl>(p, EnumKeyDoesNotExistErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EnumKeyDoesNotExistErrorQueryBuilderDsl, string> ConflictingEnumKey()
        {
            return new ComparisonPredicateBuilder<EnumKeyDoesNotExistErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingEnumKey")),
            p => new CombinationQueryPredicate<EnumKeyDoesNotExistErrorQueryBuilderDsl>(p, EnumKeyDoesNotExistErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EnumKeyDoesNotExistErrorQueryBuilderDsl, string> ConflictingAttributeName()
        {
            return new ComparisonPredicateBuilder<EnumKeyDoesNotExistErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingAttributeName")),
            p => new CombinationQueryPredicate<EnumKeyDoesNotExistErrorQueryBuilderDsl>(p, EnumKeyDoesNotExistErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
