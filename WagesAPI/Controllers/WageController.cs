using Microsoft.AspNetCore.Mvc;

namespace WagesAPI.Controllers;


[ApiController]
[Route("[controller]/[action]")]
public class WageController: ControllerBase
{
    [HttpPost]
    public IEnumerable<WeatherForecast> Add()
    {
        
    }
    
    [HttpPut]
    [ValidationFilter]
    public async Task<FuncResult> Update(CreateVisitorsCommand createBrandRequestModel, CancellationToken token)
    {
        var res = await _mediator.Send(createBrandRequestModel, token);
        return FuncResult.CreateOkResult(res);
    }
    
    
    
    [HttpDelete("{Id}")]
    [ValidationFilter(true)]
    public async Task<FuncResult> Delete([FromRoute] DeleteVisitorsCommand command, CancellationToken token)
    {
        var res = await _mediator.Send(command, token);
        return FuncResult.CreateOkResult();
    }

    
    [HttpGet]
    [ValidationFilter(true)]
    public async Task<FuncResult> Get([FromQuery] GetVisitorAreaQuery query, CancellationToken token)
    {
        var res = await _mediator.Send(query, token);
        return FuncResult.CreateGetResult(res);
    }
    
    [HttpGet]
    [ValidationFilter(true)]
    public async Task<FuncResult> GetRange([FromQuery] GetVisitorAreaQuery query, CancellationToken token)
    {
        var res = await _mediator.Send(query, token);
        return FuncResult.CreateGetResult(res);
    }
}