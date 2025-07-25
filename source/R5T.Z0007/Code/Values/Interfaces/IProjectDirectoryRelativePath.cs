using System;

using R5T.T0131;


namespace R5T.Z0007
{
	[ValuesMarker]
	public interface IProjectDirectoryRelativePath : IValuesMarker
	{
		public string InstanceClassesDirectory => @"Code\ΩInstances";

		
		public string Demonstrations_Draft_Interfaces_Directory => @"Code\Examinations\Demonstrations-Draft";

        /// <summary>
        /// <para><value>Code\Examinations\Demonstrations</value></para>
        /// </summary>
        public string Demonstrations_Interfaces_Directory => @"Code\Examinations\Demonstrations";

		public string Experiments_Draft_Interfaces_Directory => @"Code\Examinations\Experiments-Draft";

        /// <summary>
        /// <para><value>Code\Examinations\Experiments</value></para>
        /// </summary>
		public string Experiments_Interfaces_Directory => @"Code\Examinations\Experiments";

		public string Explorations_Draft_Interfaces_Directory => @"Code\Examinations\Explorations-Draft";

        /// <summary>
        /// <para><value>Code\Examinations\Explorations</value></para>
        /// </summary>
		public string Explorations_Interfaces_Directory => @"Code\Examinations\Explorations";

		public string Functionality_Draft_Interfaces_Directory => @"Code\Functionality-Draft";

        /// <summary>
        /// <para><value>Code\Functionality</value></para>
		/// OLD
        /// </summary>
        public string Functionality_Interfaces_Directory => @"Code\Functionality";

        /// <summary>
        /// <para><value>Code\Functions</value></para>
        /// </summary>
        public string Functions_Interfaces_Directory => @"Code\Functions";

        /// <summary>
        /// <para><value>Code\Scripts</value></para>
        /// </summary>
        public string Scripts_Interfaces_Directory => @"Code\Scripts";

        public string Tries_Interfaces_Directory => @"Code\Tries";

		public string Values_Draft_Interfaces_Directory => @"Code\Values-Draft";
		public string Values_Interfaces_Directory => @"Code\Values";
	}
}