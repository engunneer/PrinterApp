using System;
using System.IO;
using Newtonsoft.Json;

namespace PrinterApp.Models
{
    public class Settings
    {
        public string S { get; set; }


        //settings to be loaded from file, so we can store secret things like API keys
        public void Load(string filename)
        {
            using (var tReader = new StreamReader(filename))
            {
                using (var jReader = new JsonTextReader(tReader))
                {
                    while (jReader.Read())
                    {
                        if (jReader.Value != null)
                        {
                            Console.WriteLine("Token: {0}, Value: {1}", jReader.TokenType, jReader.Value);
                        }
                        else
                        {
                            Console.WriteLine("Token: {0}", jReader.TokenType);
                        }
                    }
                }
            }
            S = "";
        }

    }
}