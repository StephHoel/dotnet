using System;
using System.IO;
using System.Configuration;

namespace CadastroDeSeries
{
    public class Arquivo
    {
        protected internal static string path = "DataBase/sample.db";
        
        protected internal static void ListarTudo()
        {
            Console.WriteLine("**Lista de Séries Cadastradas**");
            try
            {
                string[] readText = File.ReadAllLines(path);
                
                if(readText.Length != 0)
                {
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
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        protected internal static void ListarNaoExcluida()
        {
            Console.WriteLine("**Lista de Séries Cadastradas**");
            try
            {
                string[] readText = File.ReadAllLines(path);
                
                if(readText.Length != 0)
                {
                    bool vazio = false;
                    foreach (string line in readText)
                    {
                        var lineSplit = line.Split('|');
                        if(!bool.Parse(lineSplit[5]))
                        {
                            Console.WriteLine("#ID {0}: - {1}", lineSplit[0], lineSplit[1]);
                            vazio = false;
                        }
                        else vazio = true;
                    }
                    if(vazio) Console.WriteLine("Nenhuma série cadastrada");
                }
                else Console.WriteLine("Nenhuma série cadastrada");
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
        
        protected internal static void ListarExcluida()
        {
            Console.WriteLine("**Lista de Séries Cadastradas**");
            try
            {
                string[] readText = File.ReadAllLines(path);
                
                if(readText.Length != 0)
                {
                    bool vazio = true;
                    foreach (string line in readText)
                    {
                        var lineSplit = line.Split('|');
                        if(bool.Parse(lineSplit[5]))
                        {
                            Console.WriteLine("#ID {0}: - {1}", lineSplit[0], lineSplit[1]);
                            vazio = true;
                        }
                        else vazio = false;
                    }
                    if(!vazio) Console.WriteLine("Nenhuma série cadastrada");
                }
                else Console.WriteLine("Nenhuma série cadastrada");
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        protected internal static void Escrever(string texto)
        {
            try
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(texto);
                    }	
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(texto);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        protected internal static void Alterar(string[] novoTexto)
        {
            try
            {
                if (File.Exists(path))
				{
					using (StreamWriter sw = File.CreateText(path))
					{
						foreach (string line in novoTexto)
						{
							sw.WriteLine(line);
						}
					}
				}
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        protected internal static int ProximoId()
        {
            string[] readText = File.ReadAllLines(path);
            return readText.Length;
        }
    }
}