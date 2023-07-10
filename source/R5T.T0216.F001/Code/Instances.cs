using System;


namespace R5T.T0216.F001
{
    public static class Instances
    {
        public static F0002.IPathOperator PathOperator => F0002.PathOperator.Instance;
        public static IVersionedDirectoryNameOperator VersionedDirectoryNameOperator => F001.VersionedDirectoryNameOperator.Instance;
        public static L0035.IVersionOperator VersionOperator => L0035.VersionOperator.Instance;
    }
}