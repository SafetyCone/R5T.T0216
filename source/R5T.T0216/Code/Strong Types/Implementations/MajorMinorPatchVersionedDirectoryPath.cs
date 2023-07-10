using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0216.N001
{
    /// <inheritdoc cref="IMajorMinorPatchVersionedDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class MajorMinorPatchVersionedDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IMajorMinorPatchVersionedDirectoryPath
    {
        public MajorMinorPatchVersionedDirectoryPath(string value)
            : base(value)
        {
        }
    }
}