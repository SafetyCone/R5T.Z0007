using System;

using R5T.T0131;


namespace R5T.Z0007
{
	[ValuesMarker]
	public interface IProjectDirectoryRelativePath : IValuesMarker
	{
		public string InstanceClassesDirectory => @"Code\Classes\Instances";

		public string Demonstrations_Draft_Classes_Directory => @"Code\Examinations\Demonstrations-Draft\Classes";
		public string Demonstrations_Draft_Interfaces_Directory => @"Code\Examinations\Demonstrations-Draft";

		public string Demonstrations_Classes_Directory => @"Code\Examinations\Demonstrations\Classes";
		public string Demonstrations_Interfaces_Directory => @"Code\Examinations\Demonstrations";


		public string Experiments_Draft_Classes_Directory => @"Code\Examinations\Experiments-Draft\Classes";
		public string Experiments_Draft_Interfaces_Directory => @"Code\Examinations\Experiments-Draft";

		public string Experiments_Classes_Directory => @"Code\Examinations\Experiments\Classes";
		public string Experiments_Interfaces_Directory => @"Code\Examinations\Experiments";


		public string Explorations_Draft_Classes_Directory => @"Code\Examinations\Explorations-Draft\Classes";
		public string Explorations_Draft_Interfaces_Directory => @"Code\Examinations\Explorations-Draft";

		public string Explorations_Classes_Directory => @"Code\Examinations\Explorations\Classes";
		public string Explorations_Interfaces_Directory => @"Code\Examinations\Explorations";


		public string Functionality_Draft_Classes_Directory => @"Code\Functionality-Draft\Classes";
		public string Functionality_Draft_Interfaces_Directory => @"Code\Functionality-Draft";

		public string Functionality_Classes_Directory => @"Code\Functionality\Classes";
		public string Functionality_Interfaces_Directory => @"Code\Functionality";


		public string Values_Draft_Classes_Directory => @"Code\Values-Draft\Classes";
		public string Values_Draft_Interfaces_Directory => @"Code\Values-Draft";

		public string Values_Classes_Directory => @"Code\Values\Classes";
		public string Values_Interfaces_Directory => @"Code\Values";
	}
}