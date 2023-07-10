using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0216.N001
{
    /// <summary>
    /// Strongly-types a string as a versioned directory name of the form X.Y.Z (example: 6.0.18).
    /// </summary>
    [StrongTypeMarker]
    public interface IMajorMinorPatchVersionedDirectoryName : IStrongTypeMarker,
        IDirectoryName
    {
    }
}