namespace NaszaParafia.API.Controllers;

[ApiVersion("1.0")]
[Route(ApiRoutes.BaseRoute)]
[ApiController]
public class BaseController : ControllerBase
{
    protected readonly IMapper _mapper;
    protected readonly IMediator _mediator;
    protected readonly ILogger<BaseController> _logger;

    public BaseController(IMapper mapper, IMediator mediator, ILogger<BaseController> logger)
    {
        _mapper = mapper;
        _mediator = mediator;
        _logger = logger;
    }
}