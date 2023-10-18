using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;

using R5T.T0216.Extensions;


namespace R5T.T0216.F001.Platform
{
    [FunctionalityMarker]
    public partial interface IVersionedDirectoryPathOperator : IFunctionalityMarker
    {
        public string Get_VersionedDirectoryName(string versionedDirectoryPath)
        {
            var output = Instances.PathOperator.GetDirectoryNameOfDirectoryPath(versionedDirectoryPath);
            return output;
        }

        public IDictionary<Version, string> Get_VersionedDirectoryPathsByVersion<TVersionedDirectoryPath>(
            IEnumerable<string> versionedDirectoryPaths)
        {
            var output = versionedDirectoryPaths
                .ToDictionary(
                    x => this.Get_Version(x));

            return output;
        }

        public Version Get_Version(string versionedDirectoryPath)
        {
            var directoryName = this.Get_VersionedDirectoryName(versionedDirectoryPath);

            var output = Instances.VersionedDirectoryNameOperator._Platform.Get_Version(directoryName);
            return output;
        }
    }
}
