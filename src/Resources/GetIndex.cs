using Simple.Web.Behaviors;
using Simple.Web.Windsor.Owin.Services;

namespace Simple.Web.Windsor.Owin.Resources
{
    [UriTemplate("/resources/home")]
    public class GetIndex : IGet, IOutput<RawHtml>
    {
        readonly DataService _dataService;

        public GetIndex(DataService dataService)
        {
            _dataService = dataService;
        }
        public Status Get()
        {
            this.Output = "OwinHost runnnig Simple.Web!";

            return 200;
        }

        public RawHtml Output { get; set; }
    }
}