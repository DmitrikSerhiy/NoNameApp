﻿using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace API.Infrastructure.Extensions {
    public static class MvcOptions {
        public static void AddMvcAndFilters(this IServiceCollection services) {
            services
                .AddControllersWithViews(options => {
                    options.Filters.Add(typeof(ExceptionFilter));
                    options.Filters.Add(typeof(TransactionFilter));
                })
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Startup>());
        }
    }
}
