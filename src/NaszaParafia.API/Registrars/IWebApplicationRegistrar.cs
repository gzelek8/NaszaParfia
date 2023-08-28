namespace NaszaParafia.API.Registrars
{
    public interface IWebApplicationRegistrar : IRegistrar
    {
        public void RegisterPipelineComponents(WebApplication app);
    }
}
