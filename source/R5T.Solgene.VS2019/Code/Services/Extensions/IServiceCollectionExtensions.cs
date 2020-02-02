using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Solgene.VS2019
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="VisualStudio2019SolutionFileGenerator"/> implementation of <see cref="IVisualStudio2019SolutionFileGenerator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVisualStudio2019SolutionFileGenerator(this IServiceCollection services)
        {
            services.AddSingleton<IVisualStudio2019SolutionFileGenerator, VisualStudio2019SolutionFileGenerator>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudio2019SolutionFileGenerator"/> implementation of <see cref="IVisualStudio2019SolutionFileGenerator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IVisualStudio2019SolutionFileGenerator> AddVisualStudio2019SolutionFileGeneratorAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IVisualStudio2019SolutionFileGenerator>(() => services.AddVisualStudio2019SolutionFileGenerator());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileGenerator"/> implementation of <see cref="IVisualStudioSolutionFileGenerator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVisualStudioSolutionFileGenerator(this IServiceCollection services,
            ServiceAction<IVisualStudio2019SolutionFileGenerator> addVisualStudio2019SolutionFileGenerator)
        {
            services
                .AddSingleton<IVisualStudioSolutionFileGenerator, VisualStudioSolutionFileGenerator>()
                .RunServiceAction(addVisualStudio2019SolutionFileGenerator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileGenerator"/> implementation of <see cref="IVisualStudioSolutionFileGenerator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IVisualStudioSolutionFileGenerator> AddVisualStudioSolutionFileGeneratorAction(this IServiceCollection services,
            ServiceAction<IVisualStudio2019SolutionFileGenerator> addVisualStudio2019SolutionFileGenerator)
        {
            var serviceAction = new ServiceAction<IVisualStudioSolutionFileGenerator>(() => services.AddVisualStudioSolutionFileGenerator(addVisualStudio2019SolutionFileGenerator));
            return serviceAction;
        }
    }
}
