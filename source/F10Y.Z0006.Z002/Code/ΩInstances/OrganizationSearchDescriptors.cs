using System;


namespace F10Y.Z0006.Z002
{
    public class OrganizationSearchDescriptors : IOrganizationSearchDescriptors
    {
        #region Infrastructure

        public static IOrganizationSearchDescriptors Instance { get; } = new OrganizationSearchDescriptors();


        private OrganizationSearchDescriptors()
        {
        }

        #endregion
    }
}
