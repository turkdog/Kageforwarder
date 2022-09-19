using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KageForwarder
{
    public class Encrypt
    {
		public static string EncryptMessage(string text)
		{
			byte[] texts = Convert.FromBase64String(text);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 256;
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.Key = Encoding.Default.GetBytes("encryptionkeykey");
			rijndaelManaged.GenerateIV();
			string str = "-[--IV-[-" + Encoding.Default.GetString(rijndaelManaged.IV);
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			return Convert.ToBase64String(Encoding.Default.GetBytes(Encoding.Default.GetString(cryptoTransform.TransformFinalBlock(texts, 0, text.Length)) + str));
		}

		public static string DecryptMessage(string text)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 256;
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.Key = Encoding.Default.GetBytes("encryptionkeykey");
			text = Encoding.Default.GetString(Convert.FromBase64String(text));
			string text2 = text;
			text2 = text2.Substring(text2.IndexOf("-[--IV-[-") + 9);
			text = text.Replace("-[--IV-[-" + text2, "");
			text = Convert.ToBase64String(Encoding.Default.GetBytes(text));
			rijndaelManaged.IV = Encoding.Default.GetBytes(text2);
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			byte[] array = Convert.FromBase64String(text);
			return Encoding.Default.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
		}

		public const string key = "encryptionkeykey";
	}
}
