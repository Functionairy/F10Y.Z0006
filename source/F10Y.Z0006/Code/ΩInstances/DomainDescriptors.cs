using System;


namespace F10Y.Z0006
{
    public class DomainDescriptors : IDomainDescriptors
    {
        #region Infrastructure

        public static IDomainDescriptors Instance { get; } = new DomainDescriptors();


        private DomainDescriptors()
        {
        }

        #endregion
    }
}
