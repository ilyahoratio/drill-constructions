using System.Configuration;

namespace DrillConstructions.AppConfiguration
{
		public static class Configuration
		{
				public static string GetDefaultLanguageStorage()
				{
						return ConfigurationManager.AppSettings["defaultStorage"];
				}
		}
}
