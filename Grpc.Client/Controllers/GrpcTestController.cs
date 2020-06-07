using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static Grpc.Service.material;

namespace Grpc.Client.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GrpcTestController : ControllerBase
    {
        public GrpcTestController()
        {
           
        }

        [HttpGet]
        public MaterialReturn Get([FromServices]materialClient service)
        {
            MaterialReturn r=null;
            try
            {
                r = service.Add(new MaterialModel { Sn="123123",KeypartNo = "abc",Quantity=10 });
            }
            catch (Exception ex)
            {
                r=new MaterialReturn{Message=ex.Message,Ret=false,Status=500};
            }
            return r;
        }

    }
}
