
// Application code should start here.

using Jasarsoft.Example.SendEmail;
using Jasarsoft.Example.SendEmail.Models;
using RestSharp;

// Example: How to send email via SMTP protocol with MailKit.
// We use SendinBlue, RestSharp and Newtonsoft;
// Documentation: https://developers.sendinblue.com/reference/createemailcampaign-1
Console.WriteLine("Example: Send email message via SMTP with MailKit\n");

// Replace with your API Key value
const string API_KEY = "";

// Create a rest client
var client = new RestClient("https://api.sendinblue.com/v3/smtp/email");

// Create a request
var request = new RestRequest("", Method.Post);
request.AddHeader("Accept", "application/json");
request.AddHeader("content-type", "application/json");
request.AddHeader("api-key", API_KEY);

// Create a body
var body = new RequestBody()
{
    Sender = new RequestEmailInfoModel("SenderName", "sendername@jasarsoft.com"),
    To = new List<RequestEmailInfoModel>()
    {
        new ("ToName", "toname@jasarsoft.com")
    },
    Subject = "Subject email",
    HtmlContent = "<!DOCTYPE html> <html> <body> <h1>Test email header</h1> <p>An email example html content</p> </body> </html>"
};

// Serialize the body and added to request;
var restSerializer = new RestSerializer();
request.AddJsonBody(restSerializer.Serialize(body));

var response = client.Execute(request);

// Write a response stats
Console.WriteLine($"ID: {response.Content}");
Console.WriteLine($"Successful: {response.IsSuccessful}");
Console.WriteLine($"Response status: {response.ResponseStatus}");

Console.ReadKey();