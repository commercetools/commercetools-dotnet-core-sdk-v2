namespace commercetools.Sdk.Api.Predicates.Query
{
    public class PredicateOperator
    {
        public static PredicateOperator IsEqual => new PredicateOperator("=");
        public static PredicateOperator IsNotEqual => new PredicateOperator("!=");
        public static PredicateOperator IsNot => new PredicateOperator("<>");
        public static PredicateOperator IsLessThan => new PredicateOperator("<");
        public static PredicateOperator IsLessThanOrEqual => new PredicateOperator("<=");
        public static PredicateOperator IsGreaterThan => new PredicateOperator(">");
        public static PredicateOperator IsGreaterThanOrEqual => new PredicateOperator(">=");
        public static PredicateOperator IsIn => new PredicateOperator("in");

        public static PredicateOperator Is => new PredicateOperator("is");

        public static PredicateOperator Contains => new PredicateOperator("contains");
        public static PredicateOperator Within => new PredicateOperator("within");

        private readonly string _name;

        public PredicateOperator(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}