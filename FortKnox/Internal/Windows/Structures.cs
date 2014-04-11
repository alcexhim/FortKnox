using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FortKnox.Internal.Windows
{
	internal static class Structures
	{
		/// <summary>
		/// The SI_ACCESS structure contains information about an access right or default
		/// access mask for a securable object. The ISecurityInformation::GetAccessRights
		/// method uses this structure to specify information that the access control editor
		/// uses to initialize its property pages.
		/// </summary>
		public struct SI_ACCESS
		{
			public Guid pguid;
			public int /* ACCESS_MASK */ mask;
			public StringBuilder pszName;
			public Constants.SIAccessFlags dwFlags;
		}
		public struct SI_INHERIT_TYPE
		{
			public Guid pguid;
			public int dwFlags;
			public StringBuilder pszName;
		}
		public struct SI_OBJECT_INFO
		{
			Constants.SIObjectInfoFlags dwFlags;
			/// <summary>
			/// Identifies a module that contains string resources to be used in the property
			/// sheet. The ISecurityInformation::GetAccessRights and
			/// ISecurityInformation::GetInheritTypes methods can specify string resource
			/// identifiers for display names.
			/// </summary>
			IntPtr hInstance;
			/// <summary>
			/// A pointer to a null-terminated, Unicode string that names the computer on
			/// which to look up account names and SIDs. This value can be NULL to specify
			/// the local computer. The access control editor does not free this pointer.
			/// </summary>
			StringBuilder pszServerName;
			/// <summary>
			/// A pointer to a null-terminated, Unicode string that names the object being
			/// edited. This name appears in the title of the advanced security property
			/// sheet and any error message boxes displayed by the access control editor.
			/// The access control editor does not free this pointer.
			/// </summary>
			StringBuilder pszObjectName;
			/// <summary>
			/// A pointer to a null-terminated, Unicode string used as the title of the basic
			/// security property page. This member is ignored unless the SI_PAGE_TITLE flag
			/// is set in dwFlags. If the page title is not provided, a default title is used.
			/// The access control editor does not free this pointer.
			/// </summary>
			StringBuilder pszPageTitle;
			/// <summary>
			/// A GUID for the object. This member is ignored unless the SI_OBJECT_GUID flag
			/// is set in dwFlags.
			/// </summary>
			Guid guidObjectType;
		}
	}
}
