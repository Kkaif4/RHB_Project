using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TMBILL;

internal class Encryption
{
	public string EncryptString(string plainText)
	{
		string s = "RH,infinity,852";
		SHA256 sHA = SHA256.Create();
		byte[] sourceArray = sHA.ComputeHash(Encoding.ASCII.GetBytes(s));
		byte[] array = new byte[16];
		byte[] iV = array;
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.CBC;
		byte[] array2 = new byte[32];
		Array.Copy(sourceArray, 0, array2, 0, 32);
		aes.Key = array2;
		aes.IV = iV;
		MemoryStream memoryStream = new MemoryStream();
		ICryptoTransform transform = aes.CreateEncryptor();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		byte[] bytes = Encoding.ASCII.GetBytes(plainText);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		byte[] array3 = memoryStream.ToArray();
		memoryStream.Close();
		cryptoStream.Close();
		return Convert.ToBase64String(array3, 0, array3.Length);
	}

	public string DecryptString(string cipherText)
	{
		string s = "RH,infinity,852";
		SHA256 sHA = SHA256.Create();
		byte[] sourceArray = sHA.ComputeHash(Encoding.ASCII.GetBytes(s));
		byte[] array = new byte[16];
		byte[] iV = array;
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.CBC;
		byte[] array2 = new byte[32];
		Array.Copy(sourceArray, 0, array2, 0, 32);
		aes.Key = array2;
		aes.IV = iV;
		MemoryStream memoryStream = new MemoryStream();
		ICryptoTransform transform = aes.CreateDecryptor();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		string result = string.Empty;
		try
		{
			byte[] array3 = Convert.FromBase64String(cipherText);
			cryptoStream.Write(array3, 0, array3.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array4 = memoryStream.ToArray();
			result = Encoding.ASCII.GetString(array4, 0, array4.Length);
		}
		finally
		{
			memoryStream.Close();
			cryptoStream.Close();
		}
		return result;
	}
}
