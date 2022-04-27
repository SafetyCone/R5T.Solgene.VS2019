using System;

using R5T.Cambridge.Types;using R5T.T0064;


namespace R5T.Solgene.VS2019
{[ServiceImplementationMarker]
    public class VisualStudioSolutionFileGenerator : IVisualStudioSolutionFileGenerator,IServiceImplementation
    {
        private IVisualStudio2019SolutionFileGenerator VisualStudio2019SolutionFileGenerator {  get; }


        public VisualStudioSolutionFileGenerator(IVisualStudio2019SolutionFileGenerator visualStudio2019SolutionFileGenerator)
        {
            this.VisualStudio2019SolutionFileGenerator = visualStudio2019SolutionFileGenerator;
        }

        public SolutionFile GenerateVisualStudioSolutionFile()
        {
            var solutionFile = this.VisualStudio2019SolutionFileGenerator.GenerateVisualStudio2019SolutionFile();
            return solutionFile;
        }
    }
}
