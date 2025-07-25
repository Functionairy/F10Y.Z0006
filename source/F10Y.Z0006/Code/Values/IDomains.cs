using System;

using F10Y.T0003;


namespace F10Y.Z0006
{
    [ValuesMarker]
    public partial interface IDomains
    {
        /// <summary>
        /// <para><value>Files Convention</value></para>
        /// For the /Files/{Project Name}/ sub-directory convention of including files in the output directory.
        /// </summary>
        public string FilesConvention => "Files Convention";
    }
}
