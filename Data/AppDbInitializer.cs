using BakeryWallahProject.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWallahProject.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var service = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = service.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //UserTypes
                if (!context.UserTypes.Any())
                {
                    context.UserTypes.AddRange(new List<UserTypes>()
                    {
                        new UserTypes()
                        {
                            UserType = "Admin"
                        },
                        new UserTypes()
                        {
                            UserType = "Baker"
                        },
                        new UserTypes()
                        {
                            UserType = "Customer"
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
