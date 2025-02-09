﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DietPlanner.Server.BLL.ExtensionMethods
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCustomValidationResponse(this IServiceCollection services)
        {
            services.Configure<ApiBehaviorOptions>(opt =>
            {
                opt.InvalidModelStateResponseFactory = context =>
                {
                    return context.GetBadRequestResultErrorDtoForModelState();
                };
            });
        }

    }
}
