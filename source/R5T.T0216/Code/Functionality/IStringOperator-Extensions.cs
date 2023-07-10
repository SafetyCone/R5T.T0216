using System;

using R5T.T0132;


namespace R5T.T0216.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="N001.IMajorMinorPatchVersionedDirectoryName"/>
        public N001.IMajorMinorPatchVersionedDirectoryName ToMajorMinorPatchVersionedDirectoryName(string value)
        {
            var output = new N001.MajorMinorPatchVersionedDirectoryName(value);
            return output;
        }

        /// <inheritdoc cref="IVersionedDirectoryName"/>
        public IVersionedDirectoryName ToVersionedDirectoryName(string value)
        {
            var output = new VersionedDirectoryName(value);
            return output;
        }

        /// <inheritdoc cref="N001.IMajorMinorPatchVersionedDirectoryPath"/>
        public N001.IMajorMinorPatchVersionedDirectoryPath ToMajorMinorPatchVersionedDirectoryPath(string value)
        {
            var output = new N001.MajorMinorPatchVersionedDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IVersionedDirectoryPath"/>
        public IVersionedDirectoryPath ToVersionedDirectoryPath(string value)
        {
            var output = new VersionedDirectoryPath(value);
            return output;
        }
    }
}
