
using System;

namespace Knit.Editor
{
	public enum SubWindowStyle
	{
		Default,
		Preview,
		Grid,
	}
}
namespace Knit.Editor
{
	[AttributeUsage( AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public class SubWindowStyleAttribute : Attribute
	{
		public SubWindowStyleAttribute( SubWindowStyle type)
		{
			subWindowStyle = type;
		}
		public SubWindowStyle subWindowStyle;
	}
}