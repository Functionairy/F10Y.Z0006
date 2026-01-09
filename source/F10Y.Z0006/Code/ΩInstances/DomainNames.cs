using System;


namespace F10Y.Z0006
{
    public class DomainNames : IDomainNames
    {
        #region Infrastructure

        public static IDomainNames Instance { get; } = new DomainNames();


        private DomainNames()
        {
        }

        #endregion
    }
}
