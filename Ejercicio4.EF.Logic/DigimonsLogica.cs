using Ejercicio4.EF.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio4.EF.Logic
{
   public class DigimonsLogica
    {
        public List<Digimons> GetAll()
        {
            return GetDigimons(); //Metodo que retorna toda la tabla Productos
        }
        public List<Digimons> GetDigimons()
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var request = (HttpWebRequest)WebRequest.Create("https://digimon-api.vercel.app/api/digimon");
            request.Method = "GET";
            request.Accept = "application/json";
            request.ContentType = "application/json";


            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using(Stream dataStream = response.GetResponseStream())
                    {
                        using(StreamReader reader = new StreamReader(dataStream))
                        {

                            string data = reader.ReadToEnd();
                            List<Digimons> digimones = JsonConvert.DeserializeObject<List<Digimons>>(data);

                            return digimones;

                        }
                    }
                
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

    }
}
