using Newtonsoft.Json;
using System.Web.Services;
using System.Xml;

namespace LemonWayChallenge.WebService
{
    [WebService(Namespace = "http://romainduclos.com/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {
        [WebMethod]
        public int Fibonacci(int n)
        {
            if ((n < 1) || (n > 100))
            {
                return -1;
            }

            if (n <= 2)
            {
                return 1;
            }

            return Fibonacci(n - 1) +  Fibonacci(n - 2);
        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            XmlDocument document = new XmlDocument();

            try
            {
                document.LoadXml(xml);
            }
            catch (XmlException)
            {
                return "Bad Xml format";
            }

            return JsonConvert.SerializeXmlNode(document);
        }
    }
}
