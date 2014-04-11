using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace FortKnox.Internal.Windows
{
	internal static class Methods
	{
		[DllImport("aclui.dll")]
		public static extern bool EditSecurity(IntPtr hwndOwner, ref Interfaces.ISecurityInformation psi);
	}
}
