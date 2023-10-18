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
#pragma warning disable IDE1006 // Naming Styles
        public Platform.IVersionedDirectoryPathOperator _Platform => Platform.VersionedDirectoryPathOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public IVersionedDirectoryName Get_VersionedDirectoryName(IVersionedDirectoryPath versionedDirectoryPath)
        {
            var output = _Platform.Get_VersionedDirectoryName(versionedDirectoryPath.Value)
                .ToVersionedDirectoryName();

            return output;
        }

        public Dictionary<Version, TVersionedDirectoryPath> Get_VersionedDirectoryPathsByVersion<TVersionedDirectoryPath>(
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
            var output = _Platform.Get_Version(versionedDirectoryPath.Value);
            return output;
        }
    }
}
