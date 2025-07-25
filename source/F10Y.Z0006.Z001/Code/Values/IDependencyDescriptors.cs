using System;

using F10Y.T0003;

using IDependencyNames_Functionairy = F10Y.Z0009.IDependencyNames;


namespace F10Y.Z0006.Z001
{
    /// <summary>
    /// Functionairy-applicable dependency descriptors.
    /// </summary>
    [ValuesMarker]
    public partial interface IDependencyDescriptors
    {
        /// <inheritdoc cref="IDependencyNames_Functionairy.F10Y_T0003"/>
        public DependencyDescriptor_Name F10Y_T0003 => Instances.DependencyDescriptorOperator.From_Name(
            Instances.DependencyNames.F10Y_T0003);

        /// <inheritdoc cref="IDependencyNames_Functionairy.F10Y_T0011"/>
        public DependencyDescriptor_Name F10Y_T0011 => Instances.DependencyDescriptorOperator.From_Name(
            Instances.DependencyNames.F10Y_T0011);

        /// <inheritdoc cref="IDependencyNames_Functionairy.F10Y_Y0000"/>
        public DependencyDescriptor_Name F10Y_Y0000 => Instances.DependencyDescriptorOperator.From_Name(
            Instances.DependencyNames.F10Y_Y0000);
    }
}
