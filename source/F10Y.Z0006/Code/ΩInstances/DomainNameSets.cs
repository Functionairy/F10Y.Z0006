using System;


namespace F10Y.Z0006
{
    public class DomainNameSets : IDomainNameSets
    {
        #region Infrastructure

        public static IDomainNameSets Instance { get; } = new DomainNameSets();


        private DomainNameSets()
        {
        }

        #endregion
    }
}
