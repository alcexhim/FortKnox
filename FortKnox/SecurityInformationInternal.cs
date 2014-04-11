using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FortKnox
{
	internal class SecurityInformationInternal : Internal.Windows.Interfaces.ISecurityInformation
	{
		private SecurityInformation mvarSecurityInformation;

		public SecurityInformationInternal(SecurityInformation mvarSecurityInformation)
		{
			// TODO: Complete member initialization
			this.mvarSecurityInformation = mvarSecurityInformation;
		}

		public Internal.Windows.Constants.HRESULT GetAccessRights(ref Guid pguidObjectType, Internal.Windows.Constants.GetAccessRightsFlags dwFlags, Internal.Windows.Structures.SI_ACCESS[] ppAccess, ref uint pcAccesses, ref uint piDefaultAccess)
		{
			throw new NotImplementedException();
		}

		public Internal.Windows.Constants.HRESULT GetInheritTypes(Internal.Windows.Structures.SI_INHERIT_TYPE[] ppInheritTypes, ref uint pcInheritTypes)
		{
			throw new NotImplementedException();
		}

		public Internal.Windows.Constants.HRESULT GetObjectInformation(ref Internal.Windows.Structures.SI_OBJECT_INFO pObjectInfo)
		{
			throw new NotImplementedException();
		}
	}
}
