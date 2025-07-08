using System.Text.RegularExpressions;

namespace TMBILL;

internal class RegualarExpress
{
	public bool nullfield(string text)
	{
		if (text == "")
		{
			return false;
		}
		return true;
	}

	public bool doublevalue(string text)
	{
		Regex regex = new Regex("-?[0-9]\\d*(\\.\\d+)?$");
		Match match = regex.Match(text);
		if (match.Success)
		{
			return true;
		}
		return false;
	}

	public bool textonly(string text)
	{
		Regex regex = new Regex("^[a-zA-Z ]*$");
		Match match = regex.Match(text);
		if (match.Success)
		{
			return true;
		}
		return false;
	}

	public bool numericvalue(string text)
	{
		Regex regex = new Regex("^[0-9]+$");
		Match match = regex.Match(text);
		if (match.Success)
		{
			return true;
		}
		return false;
	}

	public bool pincodefiled(string text)
	{
		Regex regex = new Regex("^([1-9])([0-9]){5}$");
		Match match = regex.Match(text);
		if (match.Success)
		{
			return true;
		}
		return false;
	}

	public bool emailfield(string text)
	{
		Regex regex = new Regex("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$");
		Match match = regex.Match(text);
		if (match.Success)
		{
			return true;
		}
		return false;
	}

	public bool mobilenofield(string text)
	{
		Regex regex = new Regex("^([7-9]{1})([0-9]{9})$");
		Match match = regex.Match(text);
		if (match.Success)
		{
			return true;
		}
		return false;
	}
}
