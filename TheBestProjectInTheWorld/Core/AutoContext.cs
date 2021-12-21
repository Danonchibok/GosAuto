using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestProjectInTheWorld.MVVM.Model;

namespace TheBestProjectInTheWorld.Core
{
    class AutoContext
    {
        private static GosAutoEntities context;
        public static GosAutoEntities GetContext()
        {
            if (context == null)
            {
                context = new GosAutoEntities();
            }
            return context;
        }
    }
}
