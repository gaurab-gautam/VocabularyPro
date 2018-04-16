using System;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VocabularyProNamespace;

namespace VocabularyProNamespace
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*try
            {
                SignXMLDoc();
                
                if (!VerifySignedXML())
                {
                    MessageBox.Show("Exiting Application", "Fatal Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    Application.Exit();
                }
            }
            catch
            {
                
            }*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VocabularyPro());
        }

        /*static void SignXMLDoc()
        {
            // Generate a signing key.
            RSACryptoServiceProvider Key = new RSACryptoServiceProvider();

            // Sign the XML that was just created and save it in a  
            // new file.
            SignVerifyEnvelope.SignXmlFile(Environment.CurrentDirectory + Constants.XMLFILEPATH, 
                Environment.CurrentDirectory + @"\Data\SignedWords.xml", Key);
            Console.WriteLine("XML file signed.");
        }

        static bool VerifySignedXML()
        {
            bool result = SignVerifyEnvelope.VerifyXmlFile(Environment.CurrentDirectory + @"\Data\SignedWords.xml");

            // Display the results of the signature verification to \ 
            // the console. 
            if (result)
            {
                Console.WriteLine("The XML signature is valid.");
            }
            else
            {
                Console.WriteLine("The XML signature is not valid.");
            }

            return result;
        }*/
    }
}
