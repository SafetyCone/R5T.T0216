using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0216.N001
{
    /// <inheritdoc cref="IMajorMinorPatchVersionedDirectoryName"/>
    [StrongTypeImplementationMarker]
    public class MajorMinorPatchVersionedDirectoryName : TypedBase<string>, IStrongTypeMarker,
        IMajorMinorPatchVersionedDirectoryName
    {
        public MajorMinorPatchVersionedDirectoryName(string value)
            : base(value)
        {
        }
    }
}