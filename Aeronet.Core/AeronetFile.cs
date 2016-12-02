﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aeronet.Core
{
    public class AeronetFile
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public List<string> DataConfigs { get; private set; }

        public AeronetFile()
        {
            this.DataConfigs = new List<string>();
        }

        public AeronetFile(string dataSetFile)
        {
            this.Read(dataSetFile);
        }

        public string Save(string root, string chartSetName)
        {
            string extension = "aeronet";
            string file = System.IO.Path.Combine(root, string.Format("{0}.{1}", chartSetName, extension));
            string[] arrDatas = this.DataConfigs.ToArray();

            // apply defaults
            dynamic aeronet = new
            {
                name = this.Name,
                datapath = this.Path,
                datas = arrDatas
            };
            using (StreamWriter sw = new StreamWriter(file, false))
            {
                JsonSerializer.Create().Serialize(new JsonTextWriter(sw), aeronet);
                sw.Flush();
                sw.Close();
            }
            return file;
        }

        private void Read(string dataSetFile)
        {
            if (!File.Exists(dataSetFile))
                throw new FileNotFoundException("Not found the data set file", dataSetFile);

            string strDataSet = File.ReadAllText(dataSetFile);
            var objDataSet = (dynamic)JObject.Parse(strDataSet);

            this.Name = (string)objDataSet.name;
            this.Path = (string)objDataSet.datapath;
            this.DataConfigs = ((JArray)objDataSet.datas).Select(d => (string)d).ToList();
        }
    }
}