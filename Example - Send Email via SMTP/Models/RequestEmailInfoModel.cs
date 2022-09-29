using Newtonsoft.Json;

namespace Jasarsoft.Example.SendEmail.Models;

[Serializable]
public sealed class RequestEmailInfoModel
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    public RequestEmailInfoModel(string name, string email)
    {
        Name = name;
        Email = email;
    }
}