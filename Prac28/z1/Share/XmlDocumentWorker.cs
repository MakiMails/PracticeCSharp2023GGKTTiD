using System.Collections.Generic;
using z1.Interfaces;
using z1.Models;
using System.Xml.Linq;
using System.Linq;
using System;

namespace z1.Share
{
    internal class XmlDocumentWorker : IXmlWorker<Auto>
    {
        private int _maxId;
        private XDocument _doc;
        private string _pathDoc;

        public XDocument Doc
        {
            get => _doc;
        }

        public void Load(string path)
        {
            _pathDoc = path;
            _doc = XDocument.Load(_pathDoc);
        }

        public void Add(Auto obj)
        {
            XElement? root = _doc.Element("autos");
            if (root != null)
            {
                root.Add(new XElement("auto",
                    new XAttribute("id", $"{++_maxId}"),
                    new XAttribute("stamp", $"{obj.Stamp}"),
                    new XAttribute("yearRelease", $"{obj.YearRelease}"),
                    new XAttribute("parkingRentalPeriod", $"{obj.ParkingRentalPeriod}")));
            }
            _doc.Save(_pathDoc);
        }

        public void Delete(int id)
        {
            XElement? root = _doc.Element("autos");
            if (root != null)
            {
                var auto = root.Elements("auto")
                    .FirstOrDefault(a => a.Attribute("id")?.Value == id.ToString());

                if(auto != null)
                {
                    auto.Remove();
                    _doc.Save(_pathDoc);
                }
            }
        }

        public Auto DindBy(string id)
        {
            XElement? root = _doc.Element("autos");
            if (root != null)
            {
                var auto = root.Elements("auto")
                    .FirstOrDefault(a => a.Attribute("id")?.Value == id.ToString());
                if (auto != null)
                {
                    return GetAuto(auto);
                }
            }
            return null;
        }

        public List<Auto> GetAll()
        {
            var elems = _doc.Element("autos")?
                .Elements("auto").ToList();
            List<Auto> autos = new List<Auto>();
            foreach(var e in elems)
            {
                Auto a = GetAuto(e);
                if(_maxId < a.ID)
                {
                    _maxId = a.ID;
                }
                autos.Add(a);
            }
            return autos;
        }

        private Auto GetAuto(XElement xAuto)
        {
            try
            {
                int id = Convert.ToInt32(xAuto.Attribute("id").Value);
                string stamp = xAuto.Attribute("stamp").Value;
                int yearRelease = Convert.ToInt32(xAuto.Attribute("yearRelease").Value);
                int parkingRentalPeriod = Convert.ToInt32(xAuto.Attribute("parkingRentalPeriod").Value);
                return new Auto(id, stamp, yearRelease, parkingRentalPeriod);
            }
            catch(Exception ex) when (ex is FormatException ||
            ex is NullReferenceException)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
