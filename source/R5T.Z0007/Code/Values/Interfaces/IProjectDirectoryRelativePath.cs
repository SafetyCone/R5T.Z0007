using System;

using R5T.T0131;


namespace R5T.Z0007
{
	[ValuesMarker]
	public interface IProjectDirectoryRelativePath : IValuesMarker
	{
		public string InstanceClassesDirectory => @"Code\Classes\Instances";

		
		public string Demonstrations_Draft_Interfaces_Directory => @"Code\Examinations\Demonstrations-Draft";
        public string Demonstrations_Interfaces_Directory => @"Code\Examinations\Demonstrations";
		public string Experiments_Draft_Interfaces_Directory => @"Code\Examinations\Experiments-Draft";
		public string Experiments_Interfaces_Directory => @"Code\Examinations\Experiments";
		public string Explorations_Draft_Interfaces_Directory => @"Code\Examinations\Explorations-Draft";
		public string Explorations_Interfaces_Directory => @"Code\Examinations\Explorations";

		public string Functionality_Draft_Interfaces_Directory => @"Code\Functionality-Draft";
		public string Functionality_Interfaces_Directory => @"Code\Functionality";
		public string Tries_Interfaces_Directory => @"Code\Tries";

		public string Values_Draft_Interfaces_Directory => @"Code\Values-Draft";
		public string Values_Interfaces_Directory => @"Code\Values";
	}
}