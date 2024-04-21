using System.Xml.Linq;

namespace DevPartnersRainfall.Models
{
    /// <summary>
    /// Error Detail model class
    /// </summary>
    public class ErrorDetailModel
    {
        private string pName;
        private string msg;

        /// <summary>
        /// Error Detail constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="msgs"></param>
        public ErrorDetailModel(string name, string msgs)
        {
            this.pName = name;
            this.msg = msgs;
        }
        /// <summary>
        /// Property Name
        /// </summary>
        public string PropertyName {
            get { return pName; }
            set { pName = value; }
        }
        /// <summary>
        /// Message
        /// </summary>
        public string Message {
            get { return msg; }
            set { msg = value; }
        }
    }
}
