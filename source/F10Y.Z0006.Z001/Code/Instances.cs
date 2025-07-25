using System;


namespace F10Y.Z0006.Z001
{
    public static class Instances
    {
        /// <inheritdoc cref="Z0009.IDependencyNames"/>
        public static Z0009.IDependencyNames DependencyNames => Z0009.DependencyNames.Instance;

        /// <inheritdoc cref="L0026.T001.IDependencyDescriptorOperator"/>
        public static L0026.T001.IDependencyDescriptorOperator DependencyDescriptorOperator => L0026.T001.DependencyDescriptorOperator.Instance;

        /// <inheritdoc cref="IDependencyDescriptors"/>
        public static IDependencyDescriptors DependencyDescriptors => Z001.DependencyDescriptors.Instance;

        /// <inheritdoc cref="L0026.T001.IDependencySetDescriptorOperator"/>
        public static L0026.T001.IDependencySetDescriptorOperator DependencySetDescriptorOperator => L0026.T001.DependencySetDescriptorOperator.Instance;
    }
}