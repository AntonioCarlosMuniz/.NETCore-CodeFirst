using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebAPI.ViewModel
{
    public abstract class Beverage
    {
        protected abstract string Description
        {
            get;
        }

        public string GetBeverageDesctription
        {
            get
            {
                return Description;
            }
        }
    }

    public class HouseBlend:Beverage
    {
        protected override string Description
        {
            get => "House Blend";
        }
    }
}
