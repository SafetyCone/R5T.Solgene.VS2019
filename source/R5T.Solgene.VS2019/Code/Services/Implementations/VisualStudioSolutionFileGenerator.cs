using System;

using R5T.Cambridge.Types;


namespace R5T.Solgene.VS2019
{
    public class VisualStudioSolutionFileGenerator : IVisualStudioSolutionFileGenerator
    {
        public SolutionFile GenerateSolutionFile()
        {
            var solutionFile = SolutionFileGenerator.NewVisualStudio2019();
            return solutionFile;
        }
    }
}
