namespace commercetools.Sdk.Api.Predicates.Query
{
    public class ConstantQueryPredicate : IConstantPredicate, IQueryPredicate {
    
        private readonly string _constant;

        public ConstantQueryPredicate(string constant) {
            this._constant = constant;
        }

        public ConstantQueryPredicate() {
            this._constant = null;
        }

        public string Constant() {
            return _constant;
        }

        public ConstantQueryPredicate Constant(string constant) {
            return new ConstantQueryPredicate(constant);
        }

        public string Render() {
            return _constant;
        }
        
        public static ConstantQueryPredicate Of()
        {
            return new ConstantQueryPredicate();
        }
    }
}