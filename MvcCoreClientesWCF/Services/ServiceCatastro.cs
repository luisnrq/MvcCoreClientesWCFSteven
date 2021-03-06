using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using MvcCoreClientesWCF.Models;
using ReferenceCatastro;

namespace MvcCoreClientesWCF.Services
{
    public class ServiceCatastro
    {
        private CallejerodelasedeelectrónicadelcatastroSoapClient client;

        public ServiceCatastro(CallejerodelasedeelectrónicadelcatastroSoapClient client) 
        {
            this.client = client;
        }

        public async Task<List<Provincia>> GetProvincias() 
        {
            ConsultaProvincia1 response =
            await this.client.ObtenerProvinciasAsync();
            XmlNode nodo = response.Provincias;
            string dataXml = nodo.OuterXml;
            XDocument document = XDocument.Parse(dataXml);
            XNamespace ns = "http://www.catastro.meh.es/";
            List<Provincia> listProvincias = new List<Provincia>();
            var consulta = from datos in document.Descendants(ns + "prov")
                           select datos;
            foreach (XElement dato in consulta) 
            {
                string cp = dato.Element(ns + "cpine").Value;
                string nombreProvincia = dato.Element(ns +"np").Value;
                Provincia p = new Provincia { IdProvincia = cp, Nombre = nombreProvincia };
                listProvincias.Add(p);
            }
            return listProvincias;
        }

        public async Task<List<string>> GetMunicipios(string provincia) 
        {
            ConsultaMunicipio1 response = 
            await this.client.ObtenerMunicipiosAsync(provincia,null);
            XmlNode nodo = response.Municipios;
            string dataXml = nodo.OuterXml;

            XDocument document = XDocument.Parse(dataXml);
            XNamespace ns = "http://www.catastro.meh.es/";
            List<string> listMunicipios = new List<string>();
            var consulta = from datos in document.Descendants(ns + "muni")
                           select datos;
            foreach (XElement dato in consulta)
            {
                string nm = dato.Element(ns + "nm").Value;
                listMunicipios.Add(nm);
            }
            return listMunicipios;
        }
    }
}
