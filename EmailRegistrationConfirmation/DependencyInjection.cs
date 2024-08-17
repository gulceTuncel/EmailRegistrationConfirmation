using EmailRegister.MailServices;
using EmailRegister.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;



namespace EmailRegister
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
           
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseLazyLoadingProxies();

                options.UseSqlServer("Data Source=VENUS-FLYTRAP;Initial Catalog=HS15_Register;Integrated Security=True;TrustServerCertificate=True");
            });

            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<AppDbContext>()
                    .AddDefaultTokenProviders();

            services.AddScoped<IMailService, MailService>();


            return services;
        }

    }
}
