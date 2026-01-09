using System;

using F10Y.T0003;


namespace F10Y.Z0006
{
    /// <summary>
    /// Functionairy-specific domain descriptors.
    /// </summary>
    [ValuesMarker]
    public partial interface IDomainDescriptors
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IDomainNames _DomainNames => Instances.DomainNames;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="IDomainNames.FilesConvention"/>
        public DomainDescriptor FilesConvention => Instances.DomainDescriptorOperator.From_Domain(
            _DomainNames.FilesConvention);
    }
}
