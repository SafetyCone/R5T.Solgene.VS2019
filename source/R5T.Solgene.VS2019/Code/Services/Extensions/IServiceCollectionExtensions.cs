using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Solgene.VS2019
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileGenerator"/> implementation of <see cref="IVisualStudioSolutionFileGenerator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVS2019VisualStudioSolutionFileGenerator(this IServiceCollection services)
        {
            services.AddSingleton<IVisualStudioSolutionFileGenerator, VisualStudioSolutionFileGenerator>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileGenerator"/> implementation of <see cref="IVisualStudioSolutionFileGenerator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IVisualStudioSolutionFileGenerator> AddVS2019VisualStudioSolutionFileGeneratorAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IVisualStudioSolutionFileGenerator>(() => services.AddVS2019VisualStudioSolutionFileGenerator());
            return serviceAction;
        }
    }
}
