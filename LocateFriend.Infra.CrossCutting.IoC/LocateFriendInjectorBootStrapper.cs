using Locate.Domain.Interfaces.Repositories;
using Locate.Domain.Interfaces.Services;
using Locate.Domain.Services;
using LocateFriend.Application;
using LocateFriend.Application.Interfaces;
using LocateFriend.Infra.Data.Context;
using LocateFriend.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LocateFriend.Infra.CrossCutting.IoC
{
    public class LocateFriendInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {

            services.AddScoped<IFriendAppService, FriendAppService>();
            services.AddScoped<ILocationAppService, LocationAppService>();

            services.AddScoped<IFriendService, FriendService>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IMapService, MapService>();

            services.AddScoped<IFriendRepository, FriendRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IMapRepository, MapRepository>();
            services.AddScoped<LocateFriendContext>();
        }
    }
}
