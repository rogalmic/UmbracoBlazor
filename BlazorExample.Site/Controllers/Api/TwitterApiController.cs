using Umbraco.Cms.Web.BackOffice.Controllers;
using System.Threading.Tasks;
using BlazorExample.Shared.Models.Config;
using Microsoft.Extensions.Options;
using Umbraco.Extensions;

namespace BlazorExample.Site.Controllers.Api;

public class TwitterApiController : UmbracoAuthorizedApiController
{
    
    private readonly BlazorExampleAppSettings _blazorExampleAppSettings;
    public TwitterApiController(IOptions<BlazorExampleAppSettings> options)
    {
        _blazorExampleAppSettings = options.Value;
    }

    public bool HasTwitterSettings()
    {
        var hasSettings = _blazorExampleAppSettings.TwitterApiCredentials?.ApiKey.IsNullOrWhiteSpace() == false &&
                          _blazorExampleAppSettings.TwitterApiCredentials?.ApiKeySecret.IsNullOrWhiteSpace() == false &&
                          _blazorExampleAppSettings.TwitterApiCredentials?.AccessToken.IsNullOrWhiteSpace() == false &&
                          _blazorExampleAppSettings.TwitterApiCredentials?.AccessTokenSecret.IsNullOrWhiteSpace() == false;
        return hasSettings;
    }
    
    public async Task<string[]> GetUmbracoTweets()
    {
        //var userClient = new TwitterClient(_blazorExampleAppSettings.TwitterApiCredentials?.ApiKey, 
        //    _blazorExampleAppSettings.TwitterApiCredentials?.ApiKeySecret, 
        //    _blazorExampleAppSettings.TwitterApiCredentials?.AccessToken, 
        //    _blazorExampleAppSettings.TwitterApiCredentials?.AccessTokenSecret);
        //var searchResponse = await userClient.SearchV2.SearchTweetsAsync("#umbraco");
        //var tweets = searchResponse.Tweets;
        return new[] { "Tweet1", "Tweet2" } ;
    }
}