using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FortKnox
{
	public class EditSecurityDialog
	{
		private SecurityInformation mvarSecurityInformation = null;
		public SecurityInformation SecurityInformation { get { return mvarSecurityInformation; } set { mvarSecurityInformation = value; } }

		public DialogResult ShowDialog()
		{
			return ShowDialog(null);
		}
		public DialogResult ShowDialog(IWin32Window parent)
		{
			IntPtr parentHwnd = IntPtr.Zero;
			if (parent != null) parentHwnd = parent.Handle;

			Internal.Windows.Interfaces.ISecurityInformation isi = new SecurityInformationInternal(mvarSecurityInformation);
			if (Internal.Windows.Methods.EditSecurity(parentHwnd, ref isi))
			{
				return DialogResult.OK;
			}
			return DialogResult.Cancel;
		}
	}
}
