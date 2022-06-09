using System;


namespace R5T.Z0007
{
	public class ProjectDirectoryRelativePath : IProjectDirectoryRelativePath
	{
		#region Infrastructure

		public static ProjectDirectoryRelativePath Instance { get; } = new();

		private ProjectDirectoryRelativePath()
		{
		}

		#endregion
	}
}