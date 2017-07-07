using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECA.Models;

namespace ECA.Data
{
    public static class OrgDbInitializer
    {
        public static void Initialize (TestOrgDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Tests.Any())
            {
                return;
            }
            var tests = new Test[]
            {
                new Test{Message="First Message"},
                new Test {Message="Second Message"}

            };
            foreach (Test t in tests)
            {
                context.Add(t);
            }
            context.SaveChanges();
        }
    }
}
