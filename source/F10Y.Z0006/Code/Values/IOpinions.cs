using System;

using F10Y.T0003;


namespace F10Y.Z0006
{
    [ValuesMarker]
    public partial interface IOpinions
    {
        /// <summary>
        /// <para><value>Organizational-Functionairy</value></para>
        /// </summary>
        public string Organizational_Functionairy => "Organizational-Functionairy";

        /// <summary>
        /// <para><value>Uses Extended Standard Types</value></para>
        /// Should there be a FileCopyPair type in the .NET Standard library, with Source and Destination properties?
        /// Should there be as WasFound&lt;T&gt; type in the .NET Standard library, that greatly simplifies the typical Has(out value):bool scenario to Has():WasFound.
        /// </summary>
        public string Uses_Extended_Standard_Types => "Uses Extended Standard Types";

        /// <summary>
        /// <para><value>Uses Expectations for Testing</value></para>
        /// Expectation types.
        /// </summary>
        public string Uses_ExpectationsForTesting => "Uses Expectations for Testing";

        /// <summary>
        /// <para><value>Uses Overload Types</value></para>
        /// Overload types are structs that serve to indicate what a function does.
        /// </summary>
        public string Uses_Overload_Types => "Uses Overload Types";

        /// <summary>
        /// <para><value>Uses Overload Token Types</value></para>
        /// Overload tokens are structs used to allow the same function name to be used for multiple functions (for example, OverloadToken_Output&lt;T&gt; allows functions to differ based on their output type by using an input overload token).
        /// </summary>
        public string Uses_OverloadToken_Types => "Uses Overload Token Types";
    }
}
