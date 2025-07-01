// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyPaymentSetMethodInfoCustomFieldActionQueryBuilderDsl
    {
        public MyPaymentSetMethodInfoCustomFieldActionQueryBuilderDsl()
        {
        }

        public static MyPaymentSetMethodInfoCustomFieldActionQueryBuilderDsl Of()
        {
            return new MyPaymentSetMethodInfoCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyPaymentSetMethodInfoCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyPaymentSetMethodInfoCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyPaymentSetMethodInfoCustomFieldActionQueryBuilderDsl>(p, MyPaymentSetMethodInfoCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyPaymentSetMethodInfoCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<MyPaymentSetMethodInfoCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<MyPaymentSetMethodInfoCustomFieldActionQueryBuilderDsl>(p, MyPaymentSetMethodInfoCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyPaymentSetMethodInfoCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<MyPaymentSetMethodInfoCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<MyPaymentSetMethodInfoCustomFieldActionQueryBuilderDsl>(p, MyPaymentSetMethodInfoCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
