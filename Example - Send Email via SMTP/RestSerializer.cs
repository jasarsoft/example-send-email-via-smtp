using Newtonsoft.Json;
using RestSharp.Serializers;

namespace Jasarsoft.Example.SendEmail;

public class RestSerializer : ISerializer
{
    private readonly JsonSerializer _serializer;

    public RestSerializer()
    {
        _serializer = new JsonSerializer
        {
            MissingMemberHandling = MissingMemberHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Include
        };
    }

    public string ContentType
    {
        get => "application/json";
        set { }
    }

    public string Serialize(object obj)
    {
        using var stringWriter = new StringWriter();
        using var jsonTextWriter = new JsonTextWriter(stringWriter)
        {
            QuoteChar = '"'
        };

        _serializer.Serialize(jsonTextWriter, obj);

        var result = stringWriter.ToString();
        return result;
    }
}