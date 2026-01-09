using System;

using F10Y.T0003;


namespace F10Y.Z0006
{
    /// <summary>
    /// Functionairy-applicable applicability values.
    /// </summary>
    /// <remarks>
    /// Note: should be in a Functionairy library comparable to F10Y.Z0008.
    /// </remarks>
    [ValuesMarker]
    [DomainDescriptor(Z0008.IDomainNames.Applicability_Names_Constant)]
    public partial interface IApplicabilities
    {
        /// <summary>
        /// <para><value>Organizational-Functionairy</value></para>
        /// </summary>
        public string Organizational_Functionairy => "Organizational-Functionairy";
    }
}
