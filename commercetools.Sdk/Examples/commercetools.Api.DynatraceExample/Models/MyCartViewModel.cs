using System.Collections.Generic;

namespace commercetools.Api.DynatraceExample.Models
{
    public class MyCartViewModel
    {
        public string CartId { get; set; }
        public List<LineItemViewModel> LineItems { get; set; }

        public MyCartViewModel()
        {
            LineItems = new List<LineItemViewModel>();
        }
    }
}