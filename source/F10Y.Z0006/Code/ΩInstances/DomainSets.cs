using System;


namespace F10Y.Z0006
{
    public class DomainSets : IDomainSets
    {
        #region Infrastructure

        public static IDomainSets Instance { get; } = new DomainSets();


        private DomainSets()
        {
        }

        #endregion
    }
}
