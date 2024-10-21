using Newtonsoft.Json;
using System.Xml.Serialization;

namespace ExportarDados
{
    public static class ExportarDados<T> where T : class
    {
        public static void SalvarDados(string caminho, FormatoArquivos formato, List<T> dados)
        {
            if (string.IsNullOrEmpty(caminho))
                throw new Exception("Caminho do arquivo não informado.");

            if (formato != FormatoArquivos.Xml)
                if (formato != FormatoArquivos.Json)
                    throw new Exception("Formato de arquivo desejado não encontrado.");

            ExportData(caminho, formato, dados);
        }

        private static void ExportData(string caminho, FormatoArquivos formato, List<T> dados)
        {
            if (formato == FormatoArquivos.Xml)
            {
                //Serializar para XML      
                var serializar = new XmlSerializer(typeof(List<T>));

                try
                {
                    FileStream fs = new(caminho + "\\dados.xml", FileMode.Create);

                    using (StreamWriter streamwriter = new(fs))
                    {
                        serializar.Serialize(streamwriter, dados);
                    }

                    Console.WriteLine($"Arquivo salvo em {caminho}");
                }
                catch (Exception excecao)
                {
                    throw new Exception(excecao.Message);
                }
            }

            if (formato == FormatoArquivos.Json)
            {
                string json = JsonConvert.SerializeObject(dados, Formatting.Indented);
                try
                {
                    FileStream fs = new(caminho + "\\dados.json", FileMode.Create);

                    using (StreamWriter streamwriter = new(fs))
                    {
                        streamwriter.WriteLine(json);
                    }

                    Console.WriteLine($"Arquivo salvo em {caminho}");
                }
                catch (Exception excecao)
                {
                    throw new Exception(excecao.Message);
                }
            }
        }
    }

    public enum FormatoArquivos
    {
        Xml = 1,
        Json = 2
    }
}