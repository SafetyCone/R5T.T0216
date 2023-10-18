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
#pragma warning disable IDE1006 // Naming Styles
        public Platform.IVersionedDirectoryNameOperator _Platform => Platform.VersionedDirectoryNameOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public Version Get_Version(IVersionedDirectoryName versionedDirectoryName)
        {
            var output = _Platform.Get_Version(versionedDirectoryName.Value);
            return output;
        }

        public IVersionedDirectoryName Get_VersionedDirectoryName(Version version)
        {
            var versionName = Instances.VersionOperator.ToVersionName(version);

            var output = this.Get_VersionedDirectoryName(versionName);
            return output;
        }

        public IVersionedDirectoryName Get_VersionedDirectoryName(IVersionName versionName)
        {
            // The directory name is just the version name.
            var output = _Platform.Get_VersionedDirectoryName(versionName.Value)
                .ToVersionedDirectoryName();

            return output;
        }

        public IVersionName Get_VersionName(IVersionedDirectoryName versionedDirectoryName)
        {
            // The versioned directory name is just the version name.
            var output = _Platform.Get_VersionName(versionedDirectoryName.Value)
                .ToVersionName();

            return output;
        }
    }
}
