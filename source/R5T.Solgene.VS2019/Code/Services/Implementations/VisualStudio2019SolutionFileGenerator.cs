using System;

using R5T.Cambridge.Types;


namespace R5T.Solgene.VS2019
{
    public class VisualStudio2019SolutionFileGenerator : IVisualStudio2019SolutionFileGenerator
    {
        public SolutionFile GenerateVisualStudio2019SolutionFile()
        {
            var solutionFile = SolutionFileGenerator.NewVisualStudio2019();
            return solutionFile;
        }
    }
}
