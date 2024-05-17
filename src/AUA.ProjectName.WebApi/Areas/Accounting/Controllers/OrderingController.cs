using AUA.ProjectName.Commands.Commands.Ordering.Ordering.InsertOrder;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AUA.ProjectName.WebApi.Areas.Accounting.Controllers
{

    [ApiVersion(ApiVersionConsts.V1)]
    public class OrderingController : BaseApiController
    {

        [HttpPost]
        public async Task<ResultModel<long>> InsertAsync(InsertOrderCommand command, CancellationToken cancellationToken)
        {
          return   await RequestDispatcher.Send(command, cancellationToken);
        }

    }
}
