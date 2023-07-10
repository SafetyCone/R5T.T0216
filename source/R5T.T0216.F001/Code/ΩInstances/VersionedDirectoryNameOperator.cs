using System;


namespace R5T.T0216.F001
{
    public class VersionedDirectoryNameOperator : IVersionedDirectoryNameOperator
    {
        #region Infrastructure

        public static IVersionedDirectoryNameOperator Instance { get; } = new VersionedDirectoryNameOperator();


        private VersionedDirectoryNameOperator()
        {
        }

        #endregion
    }
}
