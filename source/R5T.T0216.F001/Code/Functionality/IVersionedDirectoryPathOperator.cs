using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;

using R5T.T0216.Extensions;


namespace R5T.T0216.F001
{
    [FunctionalityMarker]
    public partial interface IVersionedDirectoryPathOperator : IFunctionalityMarker
    {
        public IVersionedDirectoryName Get_VersionedDirectoryName(IVersionedDirectoryPath versionedDirectoryPath)
        {
            var output = Instances.PathOperator.GetDirectoryNameOfDirectoryPath(versionedDirectoryPath.Value)
                .ToVersionedDirectoryName();

            return output;
        }

        public IDictionary<Version, TVersionedDirectoryPath> Get_VersionedDirectoryPathsByVersion<TVersionedDirectoryPath>(
            IEnumerable<TVersionedDirectoryPath> versionedDirectoryPaths)
            where TVersionedDirectoryPath : IVersionedDirectoryPath
        {
            var output = versionedDirectoryPaths
                .ToDictionary(
                    x => this.Get_Version(x));

            return output;
        }

        public Version Get_Version(IVersionedDirectoryPath versionedDirectoryPath)
        {
            var directoryName = this.Get_VersionedDirectoryName(versionedDirectoryPath);

            var output = Instances.VersionedDirectoryNameOperator.Get_Version(directoryName);
            return output;
        }
    }
}
