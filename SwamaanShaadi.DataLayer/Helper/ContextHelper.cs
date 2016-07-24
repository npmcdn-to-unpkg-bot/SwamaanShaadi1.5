using SwamaanShaadi.DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DataLayer
{
    public static class ContextHelper
    {
        //Only use for short lived contexts
        public static void ApplyStateChanges(this DbContext context)
        {
            foreach (var entry in context.ChangeTracker.Entries<IObjectWithState>())
            {
                IObjectWithState stateInfo = entry.Entity;
                entry.State = StateHelper.ConvertState(stateInfo.State);
            }
        }
    }
}
