using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace VocabularyProNamespace
{
    class DataEncryptionAndDecryption
    {
        public static void SymmetricDecryptFile()
        {
            FileStream inFile = null;
            FileStream outFile = null;
            CryptoStream csDecrypt = null;

            try
            {
                string password = Environment.UserName + "?@s$W0r|>";
                string infilepath = Environment.CurrentDirectory + Constants.XMLFILEPATH;
                string outfilepath = Environment.CurrentDirectory + Constants.XMLFILEPATH;

                inFile = new FileStream(infilepath, FileMode.Open, FileAccess.Read);
                
                SymmetricAlgorithm myAlg = new RijndaelManaged();
                byte[] salt = Encoding.ASCII.GetBytes(Environment.MachineName);
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, salt);
                myAlg.Key = key.GetBytes(myAlg.KeySize / 8); // bits to bytes
                myAlg.IV = key.GetBytes(myAlg.BlockSize / 8);

                ICryptoTransform decryptor = myAlg.CreateDecryptor();
                csDecrypt = new CryptoStream(inFile, decryptor, CryptoStreamMode.Read);

                byte[] data = new byte[(int)inFile.Length];
                csDecrypt.Read(data, 0, (int)inFile.Length);

                if (inFile != null)
                    inFile.Close();

                outFile = new FileStream(outfilepath, FileMode.OpenOrCreate, FileAccess.Write);
                outFile.Write(data, 0, data.Length);
            }

            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message + "  " + exp.TargetSite);
            }

            finally
            {
                if (csDecrypt != null)
                    csDecrypt.Close();

               // if (inFile != null)
               //     inFile.Close();

                if (outFile != null)
                    outFile.Close();
            }
        }

        public static void SymmetricEncryptFile()
        {
            FileStream inFile = null;
            FileStream outFile = null;
            CryptoStream encryptStream = null;

            try
            {
                string password = Environment.UserName + "?@s$W0r|>";
                string infilepath = Environment.CurrentDirectory + Constants.XMLFILEPATH;
                string outfilepath = Environment.CurrentDirectory + Constants.XMLFILEPATH;

                inFile = new FileStream(infilepath, FileMode.Open, FileAccess.Read);
                
                // read bytes from the input file
                byte[] data = new byte[inFile.Length];
                inFile.Read(data, 0, (int)inFile.Length);

                SymmetricAlgorithm myAlg = new RijndaelManaged();
                byte[] salt = Encoding.ASCII.GetBytes(Environment.MachineName);
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, salt);
                myAlg.Key = key.GetBytes(myAlg.KeySize / 8); //bits to bytes
                myAlg.IV = key.GetBytes(myAlg.BlockSize / 8);

                if (inFile != null)
                    inFile.Close();

                ICryptoTransform encryptor = myAlg.CreateEncryptor();

                outFile = new FileStream(outfilepath, FileMode.OpenOrCreate, FileAccess.Write);
                encryptStream = new CryptoStream(outFile, encryptor, CryptoStreamMode.Write);
                encryptStream.Write(data, 0, data.Length);
            }

            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.StackTrace);
            }

            finally
            {
                if (encryptStream != null)
                    encryptStream.Close();

                //if (inFile != null)
                //    inFile.Close();
    
                if (outFile != null)
                    outFile.Close();
            }
        }
    }
}
