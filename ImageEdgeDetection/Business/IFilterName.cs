using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.Business
{
    public interface IFilterName
    {
        string GetFilterName();
        void SetFilterName(string name);
    }
}
