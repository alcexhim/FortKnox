using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FortKnox.Internal.Windows
{
	internal static class Constants
	{
		public enum HRESULT : uint
		{
			/// <summary>
			/// Operation successful
			/// </summary>
			Successful = 0x00000000,
			/// <summary>
			/// Not implemented
			/// </summary>
			NotImplemented = 0x80004001,
			/// <summary>
			/// No such interface supported
			/// </summary>
			NotSupported = 0x80004002,
			/// <summary>
			/// Pointer that is not valid
			/// </summary>
			InvalidPointer = 0x80004003,
			/// <summary>
			/// Operation aborted
			/// </summary>
			Aborted = 0x80004004,
			/// <summary>
			/// Unspecified failure
			/// </summary>
			UnspecifiedFailure = 0x80004005,
			/// <summary>
			/// Unexpected failure
			/// </summary>
			UnexpectedFailure = 0x8000FFFF,
			/// <summary>
			/// General access denied error
			/// </summary>
			AccessDenied = 0x80070005,
			/// <summary>
			/// Handle that is not valid
			/// </summary>
			InvalidHandle = 0x80070006,
			/// <summary>
			/// Failed to allocate necessary memory
			/// </summary>
			OutOfMemory = 0x8007000E,
			/// <summary>
			/// One or more arguments are not valid
			/// </summary>
			InvalidArgument = 0x80070057
		}
		public enum GetAccessRightsFlags
		{
			/// <summary>
			/// The Basic Security property sheet is being initialized.
			/// </summary>
			Basic = 0,
			EditOwner = 0x00000001,
			/// <summary>
			/// The Advanced Security property sheet includes the Audit property page.
			/// </summary>
			EditAudits = 0x00000002,
			Container = 0x00000004,
			ReadOnly = 0x00000008,
			/// <summary>
			/// The Advanced Security property sheet is being initialized.
			/// </summary>
			Advanced = 0x00000010,
			Reset = 0x00000020,
			OwnerReadonly = 0x00000040,
			/// <summary>
			/// The Advanced Security property sheet enables editing of ACEs that apply to the properties and property sets of the object.
			/// </summary>
			EditProperties = 0x00000080,
			OwnerRecurse = 0x00000100,
			NoACLProtect = 0x00000200,
			NoTreeApply = 0x00000400,
			PageTitle = 0x00000800,
			ServerIsDC = 0x00001000,
			ResetDACLTree = 0x00004000,
			ResetSACLTree = 0x00008000,
			ObjectGUID = 0x00010000,
			EditEffective = 0x00020000,
			ResetDACL = 0x00040000,
			ResetSACL = 0x00080000,
			ResetOwner = 0x00100000,
			NoAdditionalPermission = 0x00200000,
			MayWrite = 0x10000000
		}
		public enum SIAccessFlags
		{
			None = 0x00000000,
			/// <summary>
			/// The access right is displayed on the advanced security pages.
			/// </summary>
			Specific = 0x00010000,
			/// <summary>
			/// The access right is displayed on the basic security page.
			/// </summary>
			General = 0x00020000,
			/// <summary>
			/// Indicates an access right that applies only to containers. If this flag is
			/// set, the access right is displayed on the basic security page only if the
			/// ISecurityInformation::GetObjectInformation method specifies the SI_CONTAINER
			/// flag.
			/// </summary>
			Container = 0x00040000,
			/// <summary>
			/// Indicates a property-specific access right. Used with
			/// <see cref="GetAccessRightsFlags.EditProperties"/>.
			/// </summary>
			Property = 0x00080000
		}
		public enum SIObjectInfoFlags : long
		{
			/// <summary>
			/// This is the default value. The basic security property page always displays
			/// the controls for basic editing of the object's DACL. To disable these
			/// controls, set the SI_READONLY flag.
			/// </summary>
			EditPermissions = 0x00000000L,
			/// <summary>
			///		<para>
			///			If this flag is set, the Advanced button is displayed on the basic
			///			security property page. If the user clicks this button, the system
			///			displays an advanced security property sheet that enables advanced
			///			editing of the discretionary access control list (DACL) of the
			///			object.
			///		</para>
			///		<para>
			///			Combine this flag with the SI_EDIT_AUDITS, SI_EDIT_OWNER, and
			///			SI_EDIT_PROPERTIES flags to enable editing of the object's SACL,
			///			owner, and object-specific access control entries (ACEs).
			///		</para>
			/// </summary>
			Advanced = 0x00000010L,
			/// <summary>
			/// If this flag is set, a shield is displayed on the Edit button of the advanced
			/// Auditing pages. For NTFS objects, this flag is requested when the user does
			/// not have READ_CONTROL or ACCESS_SYSTEM_SECURITY access.
			/// </summary>
			AuditsElevationRequired = 0x02000000L,
			/// <summary>
			/// Indicates that the object is a container. If this flag is set, the access
			/// control editor enables the controls relevant to the inheritance of
			/// permissions onto child objects.
			/// </summary>
			Container = 0x00000004L,
			/// <summary>
			/// If this flag is set, the system disables denying an ACE. Clients of the
			/// access control editor must implement the ISecurityInformation4 interface to
			/// set this flag.
			/// </summary>
			DisableDenyACE = 0x80000000L,
			/// <summary>
			/// Combines the EditPermissions, EditOwner, and EditAudits flags.
			/// </summary>
			EditAll = (EditPermissions | EditOwner | EditAudits),
			/// <summary>
			/// If this flag is set and the user clicks the Advanced button, the system
			/// displays an advanced security property sheet that includes an Auditing
			/// property page for editing the object's SACL. To display the Advanced button,
			/// set the SI_ADVANCED flag.
			/// </summary>
			EditAudits = 0x00000002L,
			/// <summary>
			///  If this flag is set, the Effective Permissions page is displayed. This flag
			///  is ignored if the ISecurityInformation object that initialized the access
			///  control editor does not implement the IEffectivePermission interface.
			/// </summary>
			EditEffective = 0x00020000L,
			/// <summary>
			/// If this flag is set and the user clicks the Advanced button, the system
			/// displays an advanced security property sheet that includes an Owner property
			/// page for changing the object's owner. To display the Advanced button, set the
			/// SI_ADVANCED flag.
			/// </summary>
			EditOwner = 0x00000001L,
			/// <summary>
			/// If this flag is set, the system enables controls for editing ACEs that apply
			/// to the object's property sets and properties. These controls are available
			/// only on the property sheet displayed when the user clicks the Advanced button.
			/// </summary>
			EditProperties = 0x00000080L
		}
	}
}
