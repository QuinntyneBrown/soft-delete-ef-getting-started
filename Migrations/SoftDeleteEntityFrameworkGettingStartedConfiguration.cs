using SoftDeleteEntityFrameworkGettingStarted.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDeleteEntityFrameworkGettingStarted.Migrations
{
    public class SoftDeleteEntityFrameworkGettingStartedConfiguration: DbConfiguration
    {
        public SoftDeleteEntityFrameworkGettingStartedConfiguration()
        {
            AddInterceptor(new SoftDeleteInterceptor());
        }
    }
}
