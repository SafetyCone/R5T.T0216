using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0216
{
    /// <inheritdoc cref="IVersionedDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class VersionedDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IVersionedDirectoryPath
    {
        public VersionedDirectoryPath(string value)
            : base(value)
        {
        }
    }
}