using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0216.N001
{
    /// <summary>
    /// Strongly-types a string as a directory path where the directory name is a <see cref="IMajorMinorPatchVersionedDirectoryName"/>.
    /// Example: 6.0.18
    /// </summary>
    [StrongTypeMarker]
    public interface IMajorMinorPatchVersionedDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}