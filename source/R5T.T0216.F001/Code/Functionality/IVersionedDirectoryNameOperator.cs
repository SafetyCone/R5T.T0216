using System;

using R5T.T0132;
using R5T.T0185;
using R5T.T0185.Extensions;

using R5T.T0216.Extensions;


namespace R5T.T0216.F001
{
    [FunctionalityMarker]
    public partial interface IVersionedDirectoryNameOperator : IFunctionalityMarker
    {
        public Version Get_Version(IVersionedDirectoryName versionedDirectoryName)
        {
            var versionName = this.Get_VersionName(versionedDirectoryName);

            var output = Instances.VersionOperator.Get_Version(versionName);
            return output;
        }

        public IVersionedDirectoryName Get_VersionedDirectoryName(IVersionName versionName)
        {
            // The directory name is just the version name.
            var output = versionName.Value
                .ToVersionedDirectoryName();

            return output;
        }

        public IVersionName Get_VersionName(IVersionedDirectoryName versionedDirectoryName)
        {
            // The versioned directory name is just the version name.
            var output = versionedDirectoryName.Value
                .ToVersionName();

            return output;
        }
    }
}
