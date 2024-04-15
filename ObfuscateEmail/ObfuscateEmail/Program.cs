using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string email = "awesome@dotnet.com";
        string obfuscatedEmail = ObfuscateEmail2(email);
        Console.WriteLine(obfuscatedEmail);
    }
    static string ObfuscateEmail(string email)
    {
        int  indexOfSign= email.IndexOf("@");
        string username = email.Substring(0, indexOfSign);
        string domain = email.Substring(indexOfSign + 1);

        string obfuscatedUsername = new string('*', username.Length);

        return obfuscatedUsername + "@" + domain;
    }
    static string ObfuscateEmail2(string email)
    {
        string pattern = @"^(.*?)(?=@)";
        string obfuscatedEmail = Regex.Replace(email, pattern, m => new string('*', m.Length));
        return obfuscatedEmail;
    }
}