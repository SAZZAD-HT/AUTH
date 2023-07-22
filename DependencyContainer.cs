using ispat.IRepository;
using ispat.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ispat
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IAuthentication, Authentication>();
            //services.AddSingleton<TaskList.IRepository.IToken, JwtTokenService>();



        }
    }
}

