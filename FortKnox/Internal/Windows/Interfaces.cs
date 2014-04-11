using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FortKnox.Internal.Windows
{
	internal static class Interfaces
	{
		public interface ISecurityInformation
		{
			/// <summary>
			/// The GetAccessRights method requests information about the access rights that
			/// can be controlled for a securable object. The access control editor calls
			/// this method to retrieve display strings and other information used to
			/// initialize the property pages.
			/// </summary>
			/// <param name="pguidObjectType">
			/// A pointer to a GUID structure that identifies the type of object for which
			/// access rights are being requested. If this parameter is NULL or a pointer to
			/// GUID_NULL, return the access rights for the object being edited. Otherwise,
			/// the GUID identifies a child object type returned by the
			/// ISecurityInformation::GetInheritTypes method. The GUID corresponds to the
			/// InheritedObjectType member of an object-specific ACE.
			/// </param>
			/// <param name="dwFlags">
			/// A set of bit flags that indicate the property page being initialized. This
			/// value is zero if the basic security page is being initialized.
			/// </param>
			/// <param name="ppAccess">
			/// A pointer to an array of SI_ACCESS structures. The array must include one
			/// entry for each access right. You can specify access rights that apply to the
			/// object itself, as well as object-specific access rights that apply only to a
			/// property set or property on the object.
			/// </param>
			/// <param name="pcAccesses">
			/// A pointer to ULONG that indicates the number of entries in the ppAccess array.
			/// </param>
			/// <param name="piDefaultAccess">
			/// A pointer to ULONG that indicates the zero-based index of the array entry that
			/// contains the default access rights. The access control editor uses this entry
			/// as the initial access rights in a new ACE.
			/// </param>
			/// <returns>S_OK if successful, otherwise a nonzero error code.</returns>
			Constants.HRESULT GetAccessRights(ref Guid pguidObjectType, Constants.GetAccessRightsFlags dwFlags, Structures.SI_ACCESS[] ppAccess, ref uint pcAccesses, ref uint piDefaultAccess);

			/// <summary>
			/// The GetInheritTypes method requests information about how ACEs can be inherited by child objects. For more information, see ACE Inheritance.
			/// </summary>
			/// <param name="ppInheritTypes">A pointer to a variable you should set to a pointer to an array of <see cref="Structures.SI_INHERIT_TYPE" /> structures. The array should include one entry for each combination of inheritance flags and child object type that you support.</param>
			/// <param name="pcInheritTypes">A pointer to a variable that you should set to indicate the number of entries in the ppInheritTypes array.</param>
			/// <returns>S_OK if successful, otherwise a nonzero error code.</returns>
			/// <remarks>The access control editor does not free the pointer returned in ppInheritTypes.</remarks>
			Constants.HRESULT GetInheritTypes(Structures.SI_INHERIT_TYPE[] ppInheritTypes, ref uint pcInheritTypes);

			/// <summary>
			/// The GetObjectInformation method requests information that the access control
			/// editor uses to initialize its pages and to determine the editing options
			/// available to the user.
			/// </summary>
			/// <param name="pObjectInfo">
			/// A pointer to an SI_OBJECT_INFO structure. Your implementation must fill this
			/// structure to pass information back to the access control editor.
			/// </param>
			/// <returns>S_OK if successful, otherwise a nonzero error code.</returns>
			/// <remarks>The system does not free the string pointers that you return in the SI_OBJECT_INFO structure.</remarks>
			Constants.HRESULT GetObjectInformation(ref Structures.SI_OBJECT_INFO pObjectInfo);
		}
	}
}
