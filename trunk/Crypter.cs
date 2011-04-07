using System;
using System.Security.Cryptography;
class Crypter {
	public static string EncryptString(string Message, string Passphrase) {
		byte[] Results;
		System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
		MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
		byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));
		TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
		TDESAlgorithm.Key = TDESKey;
		TDESAlgorithm.Mode = CipherMode.ECB;
		TDESAlgorithm.Padding = PaddingMode.PKCS7;
		byte[] DataToEncrypt = UTF8.GetBytes(Message);
		try {
			ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
			Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
		}
		finally {
			TDESAlgorithm.Clear();
			HashProvider.Clear();
		}
		return Convert.ToBase64String(Results);
	}
	public static string DecryptString(string Message, string Passphrase) {
		byte[] Results;
		if (Message.Length == 0) return "";
		System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
		MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
		byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));
		TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
		TDESAlgorithm.Key = TDESKey;
		TDESAlgorithm.Mode = CipherMode.ECB;
		TDESAlgorithm.Padding = PaddingMode.PKCS7;
		byte[] DataToDecrypt = Convert.FromBase64String(Message);
		try {
			ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
			Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
		}
		finally {
			TDESAlgorithm.Clear();
			HashProvider.Clear();
		}
		return UTF8.GetString(Results);
	}
}