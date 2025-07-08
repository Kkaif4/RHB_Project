using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace TMBILL;

public class Permission
{
	public string IsFormAlreadyOpen(string name)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		foreach (Form item in (ReadOnlyCollectionBase)(object)Application.OpenForms)
		{
			Form val = item;
			if (((Control)val).Name == name)
			{
				return "true";
			}
		}
		return "false";
	}

	public void IsFormFocusOpen(string name)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		foreach (Form item in (ReadOnlyCollectionBase)(object)Application.OpenForms)
		{
			Form val = item;
			if (((Control)val).Name == name)
			{
				((Control)val).Focus();
				val.Activate();
			}
		}
	}

	public bool SetAcl()
	{
		FileSystemRights fileSystemRights = (FileSystemRights)0;
		fileSystemRights = FileSystemRights.FullControl;
		string name = WindowsIdentity.GetCurrent().Name;
		FileSystemAccessRule rule = new FileSystemAccessRule(name, fileSystemRights, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.CurrentDirectory);
		DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
		bool modified = false;
		accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out modified);
		if (!modified)
		{
			return false;
		}
		InheritanceFlags inheritanceFlags = InheritanceFlags.ObjectInherit;
		inheritanceFlags = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;
		rule = new FileSystemAccessRule(name, fileSystemRights, inheritanceFlags, PropagationFlags.InheritOnly, AccessControlType.Allow);
		modified = false;
		accessControl.ModifyAccessRule(AccessControlModification.Add, rule, out modified);
		if (!modified)
		{
			return false;
		}
		directoryInfo.SetAccessControl(accessControl);
		return true;
	}

	public void setDateFormat()
	{
		CultureInfo cultureInfo = new CultureInfo(CultureInfo.CurrentCulture.Name);
		cultureInfo.DateTimeFormat.ShortDatePattern = "dd'/'MM'/'yyyy";
		cultureInfo.DateTimeFormat.LongTimePattern = "hh':'mm tt";
		Thread.CurrentThread.CurrentCulture = cultureInfo;
		Thread.CurrentThread.CurrentUICulture = cultureInfo;
	}
}
