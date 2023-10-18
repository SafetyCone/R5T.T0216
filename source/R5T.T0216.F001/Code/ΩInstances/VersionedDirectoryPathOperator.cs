using System;


namespace R5T.T0216.F001
{
    public class VersionedDirectoryPathOperator : IVersionedDirectoryPathOperator
    {
        #region Infrastructure

        public static IVersionedDirectoryPathOperator Instance { get; } = new VersionedDirectoryPathOperator();


        private VersionedDirectoryPathOperator()
        {
        }

        #endregion
    }
}


namespace R5T.T0216.F001.Platform
{
    public class VersionedDirectoryPathOperator : IVersionedDirectoryPathOperator
    {
        #region Infrastructure

        public static IVersionedDirectoryPathOperator Instance { get; } = new VersionedDirectoryPathOperator();


        private VersionedDirectoryPathOperator()
        {
        }

        #endregion
    }
}
