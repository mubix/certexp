using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;

namespace certexp
{
    class Program
    {
        static void try_export(System.Security.Cryptography.X509Certificates.X509Store store, string pass)
        {
            foreach (X509Certificate2 certificate in store.Certificates)
            {
                Console.WriteLine("[+] Subject Name: " + certificate.Subject);
                Console.WriteLine("[+] Thumbprint  : " + certificate.Thumbprint);
                try
                {
                    if (certificate.PrivateKey != null)
                    {
                        Console.WriteLine("[+] Private Key : YES");
                    }
                    else
                    {
                        Console.WriteLine("[+] Private Key : NO");
                    }
                    byte[] certBytes = certificate.Export(X509ContentType.Pkcs12, pass);
                    Console.WriteLine(System.Convert.ToBase64String(certBytes));
                    Console.WriteLine("\n");
                }
                catch
                {
                    Console.WriteLine("----> COULD NOT EXPORT - NOT ADMIN OR NOT MARKED AS EXPORTABLE");
                }
            }
        }
        static void Main(string[] args)
        {
            string randompath = Path.GetRandomFileName();
            string pass = randompath.Replace(".", "");
            System.Security.Cryptography.X509Certificates.X509Store store1 = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            store1.Open(OpenFlags.ReadOnly);
            Console.WriteLine("===== System Certificates ====");
            try_export(store1, pass);
            System.Security.Cryptography.X509Certificates.X509Store store2 = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store2.Open(OpenFlags.ReadOnly);
            Console.WriteLine("\n\n===== User Certificates ======");
            try_export(store2, pass);
            Console.WriteLine($"[*] Export password is: {pass}");
        }
    }
}
