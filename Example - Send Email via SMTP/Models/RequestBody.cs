using Jasarsoft.Example.SendEmail.Models;
using Newtonsoft.Json;

namespace Jasarsoft.Example.SendEmail.Models;

[Serializable]
public sealed class RequestBody
{
    [JsonProperty("sender")]
    public RequestEmailInfoModel Sender { get; set; }

    [JsonProperty("to")]
    public List<RequestEmailInfoModel> To { get; set; }

    [JsonProperty("htmlContent")]
    public string HtmlContent { get; set; }

    [JsonProperty("subject")]
    public string Subject { get; set; }
}