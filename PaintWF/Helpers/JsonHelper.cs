using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using PaintWF.Interfaces;

namespace PaintWF.Helpers
{
    public class JsonHelper
    {
        private JsonSerializer _serializer;
        public JsonHelper()
        {
            _serializer = new JsonSerializer();
        }

        public void Serialize(string fileName, List<IFigure> figures)
        {
            if (figures == null)
                throw new ArgumentNullException("figures");
            if (figures.Count == 0)
                return;


            using (var fs = new FileStream(fileName, FileMode.Create))
            using (var sw = new StreamWriter(fs, Encoding.UTF8))
            using (var jw = new JsonTextWriter(sw))
            {
                jw.Formatting = Formatting.Indented;

                _serializer.Serialize(jw, figures);
            }
        }

        public List<IFigure> Deserialize(string fileName)
        {
            List<IFigure> figures;

            using (var fs = new FileStream(fileName, FileMode.Open))
            using (var sr = new StreamReader(fs, Encoding.UTF8))
            using (var jr = new JsonTextReader(sr))
            {
                figures = _serializer.Deserialize<List<IFigure>>(jr);
            }

            return figures;
        }
    }
}