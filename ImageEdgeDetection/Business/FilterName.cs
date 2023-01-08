using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.Business
{
    public class FilterName : IFilterName
    {
        string filterName;
        public string GetFilterName()
        {
            return filterName;
        }

        public void SetFilterName(string name)
        {
            filterName = name;
        }
    }
}
