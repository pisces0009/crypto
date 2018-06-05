using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace RSA_Assignment_2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			UnicodeEncoding ByteConverter = new UnicodeEncoding();
			RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
			byte[] plaintext;
			byte[] encryptedtext;
			Console.WriteLine("Enter value to encrypt.");
            RSAmethods obj = new RSAmethods();
			plaintext = ByteConverter.GetBytes(Console.ReadLine());
			encryptedtext = obj.Encryption(plaintext, RSA.ExportParameters(true), false);
            string path = System.IO.Directory.GetCurrentDirectory();
			StreamReader file = new StreamReader(path + @"\text.txt");
            string cipherString = file.ReadLine();
			file.Close();
			Console.WriteLine("THIS IS YOUR ENCRYPTED TEXT. \n" + ByteConverter.GetString(encryptedtext));
			byte[] decryptedtex = obj.Decryption(encryptedtext, RSA.ExportParameters(true), false);
			Console.WriteLine(" This is your Decrypted text. \n " + ByteConverter.GetString(decryptedtex));
            Console.ReadLine();
		}
        
	}
}
