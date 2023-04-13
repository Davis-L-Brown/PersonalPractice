using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using RichDataClient.Interfaces;


namespace RichDataClient.Clients
{
    public class cRichDataClient: IRichDataClient
    {
        public cRichDataClient() 
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
        }

        //public IEnumerable<Dictionary<string, string>> GetData(DateTime startDate = DateTime.Now, DateTime endDate = DateTime.Now, string asset = "", string partNumber = "", string serialNumber = "")
        //{
        //    IEnumerable<Dictionary<string, string>> data = new IEnumerable<Dictionary<string, string>>();
        //    return data;
        //}
    }
}
