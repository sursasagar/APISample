using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISample.Response
{
    public class ResponseData
    {
        public EResponse Code { get; set; }
        public bool Status { get; set; }
        public object Message { get; set; }
        public object Data { get; set; }
    }

    public enum EResponse
    {
        OK,
        UnexpectedError,
        NoData,
        ValidationError,
        NoPermission,
        UnSuccess
    }
}
