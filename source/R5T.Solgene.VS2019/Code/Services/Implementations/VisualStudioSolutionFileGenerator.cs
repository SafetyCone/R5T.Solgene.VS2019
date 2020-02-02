using System;

using R5T.Cambridge.Types;


namespace R5T.Solgene.VS2019
{
    public class VisualStudioSolutionFileGenerator : IVisualStudioSolutionFileGenerator
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
