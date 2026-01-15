using ForgeKit.Contracts.Test;
using Microsoft.AspNetCore.Mvc;

namespace ForgeKit.Controllers;

[ApiController]
[Route("api/test")]
public sealed class TestController : ControllerBase
{
    [HttpGet("ping")]
    public async Task<ActionResult<TestPingResponse>> PingAsync()
    {   
        await Task.Delay(500);
        return Ok(new TestPingResponse("pong", DateTimeOffset.UtcNow));
    }

    [HttpPost("echo")]
    public ActionResult<TestEchoResponse> Echo(TestEchoRequest request)
    {
        return Ok(new TestEchoResponse(request.Message, request.Count));
    }
}
