using System;


namespace R5T.Z0007
{
	public class ProjectDirectoryRelativePath : IProjectDirectoryRelativePath
	{
		#region Infrastructure

		public static IProjectDirectoryRelativePath Instance { get; } = new ProjectDirectoryRelativePath();

		private ProjectDirectoryRelativePath()
		{
		}

		#endregion
	}
}