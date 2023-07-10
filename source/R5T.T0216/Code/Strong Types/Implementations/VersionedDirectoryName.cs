using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0216
{
    /// <inheritdoc cref="IVersionedDirectoryName"/>
    [StrongTypeImplementationMarker]
    public class VersionedDirectoryName : TypedBase<string>, IStrongTypeMarker,
        IVersionedDirectoryName
    {
        public VersionedDirectoryName(string value)
            : base(value)
        {
        }
    }
}