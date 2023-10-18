using System;

using R5T.T0132;


namespace R5T.T0216.F001.Platform
{
    [FunctionalityMarker]
    public partial interface IVersionedDirectoryNameOperator : IFunctionalityMarker
    {
        public Version Get_Version(string versionedDirectoryName)
        {
            var versionName = this.Get_VersionName(versionedDirectoryName);

            var output = Instances.VersionOperator.Get_Version(versionName);
            return output;
        }

        public string Get_VersionedDirectoryName(string versionName)
        {
            // The directory name is just the version name.
            var output = versionName;
            return output;
        }

        public string Get_VersionName(string versionedDirectoryName)
        {
            // The versioned directory name is just the version name.
            var output = versionedDirectoryName;
            return output;
        }
    }
}
