// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class EnumKeyAlreadyExistsErrorQueryBuilderDsl
    {
        public EnumKeyAlreadyExistsErrorQueryBuilderDsl()
        {
        }

        public static EnumKeyAlreadyExistsErrorQueryBuilderDsl Of()
        {
            return new EnumKeyAlreadyExistsErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<EnumKeyAlreadyExistsErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<EnumKeyAlreadyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<EnumKeyAlreadyExistsErrorQueryBuilderDsl>(p, EnumKeyAlreadyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EnumKeyAlreadyExistsErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<EnumKeyAlreadyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<EnumKeyAlreadyExistsErrorQueryBuilderDsl>(p, EnumKeyAlreadyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EnumKeyAlreadyExistsErrorQueryBuilderDsl, string> ConflictingEnumKey()
        {
            return new ComparisonPredicateBuilder<EnumKeyAlreadyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingEnumKey")),
            p => new CombinationQueryPredicate<EnumKeyAlreadyExistsErrorQueryBuilderDsl>(p, EnumKeyAlreadyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EnumKeyAlreadyExistsErrorQueryBuilderDsl, string> ConflictingAttributeName()
        {
            return new ComparisonPredicateBuilder<EnumKeyAlreadyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingAttributeName")),
            p => new CombinationQueryPredicate<EnumKeyAlreadyExistsErrorQueryBuilderDsl>(p, EnumKeyAlreadyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
