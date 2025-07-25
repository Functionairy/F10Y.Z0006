using System;

using F10Y.T0003;


namespace F10Y.Z0006.Z002
{
    [ValuesMarker]
    public partial interface IOrganizationSearchDescriptors
    {
        public OrganizationSearchDescriptor_Name Find_F10Y => Instances.OrganizationSearchDescriptorOperator.From(
            Instances.OrganizationNames.F10Y,
            Instances.EqualityOperationDescriptors.For_String_Simple);
    }
}
