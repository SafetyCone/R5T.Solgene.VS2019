using System;

using R5T.Cambridge.Types;using R5T.T0064;


namespace R5T.Solgene.VS2019
{[ServiceImplementationMarker]
    public class VisualStudio2019SolutionFileGenerator : IVisualStudio2019SolutionFileGenerator,IServiceImplementation
    {
        public SolutionFile GenerateVisualStudio2019SolutionFile()
        {
            var solutionFile = SolutionFileGenerator.NewVisualStudio2019();
            return solutionFile;
        }
    }
}
