using System;

namespace CommonSnappableTypes
{
	public interface IAppFunctionality
	{
		void Doit();
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class CompanyInfoAttribute: System.Attribute
	{
		public string CompanyName { get; set; }
		public string CompanyUrl { get; set; }
	}
}