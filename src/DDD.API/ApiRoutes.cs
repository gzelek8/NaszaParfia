namespace DDD.API;

public static class ApiRoutes
{
    public const string BaseRoute = "api/v{version:apiVersion}/[controller]";

    public static class Pub
    {
        public const string GetPub = "{pubId}";
    }
}