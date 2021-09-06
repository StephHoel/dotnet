using System;
using System.IO;
using System.Configuration;

namespace CadastroDeSeries
{
    public class Arquivo
    {
        
        protected internal static string path = "DataBase/sample.db";
        
        protected internal static void Ler(int? id)
        {
            try
            {
                string[] readText = File.ReadAllLines(path);
                
                if(readText.Length != 0)
                {
                    // achar linha
                    // chamar alterar()
                    // escrever nova string com as novas informações na mesma linha

                    foreach (string line in readText)
                    {
                        var lineSplit = line.Split('|');
                        Console.WriteLine("#ID {0}: - {1} {2}", lineSplit[0], lineSplit[1], (bool.Parse(lineSplit[5]) ? "*Excluído*" : ""));
                    }
                }
                else Console.WriteLine("Nenhuma série cadastrada");
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            
        }

        protected internal static void Escrever(string texto)
        {
            try
            {
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(texto);
                    }	
                }
                else
                {
                    // This text is always added, making the file longer over time
                    // if it is not deleted.
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(texto);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        protected internal static void Alterar(int id, string novoTexto)
        {
            // TODO: alterar a linha número id

            // try
            // {
            //     string[] readText = File.ReadAllLines(path);
                
            //     if(readText.Length != 0)
                // {
                    
                    // achar linha
            //         // escrever nova string com as novas informações na mesma linha

            //         
            //     }
            //     else Console.WriteLine("Nenhuma série cadastrada");
            // }
            // catch(Exception e)
            // {
            //     Console.WriteLine("Exception: " + e.Message);
            // }

            // var arquivo = 
            // var appSettings = ConfigurationManager.AppSettings;  
            // string result = appSettings["key"] ?? "Not Found";  

            Console.WriteLine("entrei");
            // var linhas = File.ReadAllLines(arquivo);

            // arquivo[id] = novoTexto; // Editar linha do id

            // File.WriteAllLines(arquivo, linhas);
        }

        protected internal static int ProximoId()
        {
            string[] readText = File.ReadAllLines(path);
            return readText.Length;
        }
    }
}