using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace Grpc.Service
{
    public class MaterialService : material.materialBase
    {
        private readonly ILogger<MaterialService> _logger;
        public MaterialService(ILogger<MaterialService> logger)
        {
            _logger = logger;
        }

        public override Task<MaterialReturn> Add(MaterialModel request, ServerCallContext context)
        {
            return Task.FromResult(new MaterialReturn
            {
                Ret=true,
                Status=200,
                Message = $"材料{request.KeypartNo}，入库SN:{request.Sn}，数量：{request.Quantity}"
            });
        }

        public override Task<MaterialReturn> Reduce(MaterialModel request, ServerCallContext context)
        {
            return Task.FromResult(new MaterialReturn
            {
                Ret=true,
                Status=200,
                Message = $"材料{request.KeypartNo}，出库SN:{request.Sn}，数量：{request.Quantity}"
            });
        }
    }
}
