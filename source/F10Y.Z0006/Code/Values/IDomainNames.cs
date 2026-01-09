using System;

using F10Y.T0003;


namespace F10Y.Z0006
{
    /// <summary>
    /// Instance set functionality domain names.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [ValuesMarker]
    [DomainDescriptor(Z0008.IDomainNames.Domain_Names_Constant)]
    public partial interface IDomainNames
        // Note: do not inherit from Z0008.IDomainNames (which is referenced for the domain names constant), let this be an independent branch.
    {
        /// <summary>
        /// <para><value>Files Convention</value></para>
        /// For the /Files/{Project Name}/ sub-directory convention of including files in the output directory.
        /// </summary>
        string FilesConvention => "Files Convention";
    }
}
