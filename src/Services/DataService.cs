using System.Collections.Generic;

namespace Simple.Web.Windsor.Owin.Services
{
    public class DataService
    {
        public IList<string> _messages = new List<string>();

        public void AddMessage(string message)
        {
            _messages.Add(message);
        }
    }
}