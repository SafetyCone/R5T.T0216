using System;

using R5T.T0178;


namespace R5T.T0216
{
    /// <summary>
    /// Strongly-types a string as a versioned directory name.
    /// The major-minor-patch version format is chosen as the default (<see cref="N001.IMajorMinorPatchVersionedDirectoryName"/>, example: 6.0.18).
    /// </summary>
    [StrongTypeMarker]
    public interface IVersionedDirectoryName : IStrongTypeMarker,
        N001.IMajorMinorPatchVersionedDirectoryName
    {
    }
}