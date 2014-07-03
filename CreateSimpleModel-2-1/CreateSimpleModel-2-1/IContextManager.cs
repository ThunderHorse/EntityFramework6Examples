using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSimpleModel_2_1
{
    public interface IContextManager
    {
        EF6RecipesContext GetContextManager();
    }
}
