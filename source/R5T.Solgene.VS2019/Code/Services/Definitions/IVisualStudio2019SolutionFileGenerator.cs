using System;

using R5T.Cambridge.Types;using R5T.T0064;


namespace R5T.Solgene.VS2019
{[ServiceDefinitionMarker]
    public interface IVisualStudio2019SolutionFileGenerator:IServiceDefinition
    {
        SolutionFile GenerateVisualStudio2019SolutionFile();
    }
}
