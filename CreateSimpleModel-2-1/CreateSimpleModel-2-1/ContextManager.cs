using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSimpleModel_2_1
{
    public class ContextManager : IContextManager
    {
        public EF6RecipesContext GetContextManager()
        {
            return new EF6RecipesContext();
        }
    }
}
