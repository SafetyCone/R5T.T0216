using System;


namespace R5T.T0216.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToVersionedDirectoryName(string)"/>
        public static IVersionedDirectoryName ToVersionedDirectoryName(this string value)
        {
            return Instances.StringOperator_Extensions.ToVersionedDirectoryName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToVersionedDirectoryPath(string)"/>
        public static IVersionedDirectoryPath ToVersionedDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToVersionedDirectoryPath(value);
        }
    }
}


namespace R5T.T0216.N001.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="T0216.Extensions.IStringOperator.ToMajorMinorPatchVersionedDirectoryName(string)"/>
        public static IMajorMinorPatchVersionedDirectoryName ToMajorMinorPatchVersionedDirectoryName(this string value)
        {
            return Instances.StringOperator_Extensions.ToMajorMinorPatchVersionedDirectoryName(value);
        }

        /// <inheritdoc cref="T0216.Extensions.IStringOperator.ToMajorMinorPatchVersionedDirectoryPath(string)"/>
        public static IMajorMinorPatchVersionedDirectoryPath ToMajorMinorPatchVersionedDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToMajorMinorPatchVersionedDirectoryPath(value);
        }
    }
}
