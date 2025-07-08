using System;

namespace TMBILL;

internal class inwords
{
	public string changeToWords(string numb)
	{
		string result = "";
		string number = numb;
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = " Rupees Only.";
		try
		{
			int num = numb.IndexOf(".");
			if (num > 0)
			{
				number = numb.Substring(0, num);
				text = numb.Substring(num + 1);
			}
			result = $"{translateWholeNumber(number).Trim()} {text2}{text3} {text4}";
		}
		catch
		{
		}
		return result;
	}

	private string translateWholeNumber(string number)
	{
		string text = "";
		try
		{
			bool flag = false;
			bool flag2 = false;
			double num = Convert.ToDouble(number);
			if (num > 0.0)
			{
				flag = number.StartsWith("0");
				int length = number.Length;
				int num2 = 0;
				string text2 = "";
				switch (length)
				{
				case 1:
					text = ones(number);
					flag2 = true;
					break;
				case 2:
					text = tens(number);
					flag2 = true;
					break;
				case 3:
					num2 = length % 3 + 1;
					text2 = " Hundred ";
					break;
				case 4:
				case 5:
					num2 = length % 4 + 1;
					text2 = " Thousand ";
					break;
				case 6:
				case 7:
					num2 = length % 6 + 1;
					text2 = " Lakh ";
					break;
				case 8:
				case 9:
				case 10:
					num2 = length % 8 + 1;
					text2 = " Core ";
					break;
				default:
					flag2 = true;
					break;
				}
				if (!flag2)
				{
					if (flag)
					{
						text2 = "";
					}
					text = translateWholeNumber(number.Substring(0, num2)) + text2 + translateWholeNumber(number.Substring(num2));
					if (flag)
					{
						text = " and " + text.Trim();
					}
				}
				if (text.Trim().Equals(text2.Trim()))
				{
					text = "";
				}
			}
		}
		catch
		{
		}
		return text.Trim();
	}

	private string tens(string digit)
	{
		int num = Convert.ToInt32(digit);
		string result = null;
		switch (num)
		{
		case 10:
			result = "Ten";
			break;
		case 11:
			result = "Eleven";
			break;
		case 12:
			result = "Twelve";
			break;
		case 13:
			result = "Thirteen";
			break;
		case 14:
			result = "Fourteen";
			break;
		case 15:
			result = "Fifteen";
			break;
		case 16:
			result = "Sixteen";
			break;
		case 17:
			result = "Seventeen";
			break;
		case 18:
			result = "Eighteen";
			break;
		case 19:
			result = "Nineteen";
			break;
		case 20:
			result = "Twenty";
			break;
		case 30:
			result = "Thirty";
			break;
		case 40:
			result = "Fourty";
			break;
		case 50:
			result = "Fifty";
			break;
		case 60:
			result = "Sixty";
			break;
		case 70:
			result = "Seventy";
			break;
		case 80:
			result = "Eighty";
			break;
		case 90:
			result = "Ninety";
			break;
		default:
			if (num > 0)
			{
				result = tens(digit.Substring(0, 1) + "0") + " " + ones(digit.Substring(1));
			}
			break;
		}
		return result;
	}

	private string ones(string digit)
	{
		int num = Convert.ToInt32(digit);
		string result = "";
		switch (num)
		{
		case 1:
			result = "One";
			break;
		case 2:
			result = "Two";
			break;
		case 3:
			result = "Three";
			break;
		case 4:
			result = "Four";
			break;
		case 5:
			result = "Five";
			break;
		case 6:
			result = "Six";
			break;
		case 7:
			result = "Seven";
			break;
		case 8:
			result = "Eight";
			break;
		case 9:
			result = "Nine";
			break;
		}
		return result;
	}
}
