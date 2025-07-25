using System;

using F10Y.T0003;


namespace F10Y.Z0006.Z001
{
    /// <summary>
    /// Functionairy-specific dependency set descriptors.
    /// </summary>
    [ValuesMarker]
    public partial interface IDependencySetDescriptors
    {
        /// <summary>
        /// The <inheritdoc cref="IDependencyDescriptors.F10Y_T0003" path="descendant::value"/> values marker type set,
        /// the <inheritdoc cref="IDependencyDescriptors.F10Y_T0011" path="descendant::value"/> survey marker types set,
        /// and the <inheritdoc cref="IDependencyDescriptors.F10Y_Y0000" path="descendant::value"/> .NET Standard 2.1 documentations set.
        /// </summary>
        public DependencySetDescriptor ValuesAndSurveyMarkerTypes_AndNetStandardDocumentationsSet => Instances.DependencySetDescriptorOperator.From(
            Instances.DependencyDescriptors.F10Y_T0003,
            Instances.DependencyDescriptors.F10Y_T0011,
            Instances.DependencyDescriptors.F10Y_Y0000);
    }
}
