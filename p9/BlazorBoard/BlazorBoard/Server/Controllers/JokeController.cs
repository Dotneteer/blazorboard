using Microsoft.AspNetCore.Mvc;
using System;

namespace Dotneteer.BlazorBoard.Server.Controllers
{
    [Route("api/joke")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        private static string[] s_Jokes =
        {
            "Wife: \"It's our wedding anniversary in a week, darling. How do you think we should celebrate?\" " +
            "Husband: “With a minute of silence.”",
            "Last words of a skydiver? Oh crap, those annoying clothes moths!!!",
            "What do you give an armless child for Christmas? Nothing, he wouldn’t be able to open it anyways.",
            "Woman to her husband while at it: \"Please say dirty things to me!\" Man: \"Bath, Kitchen, Living room...\"",
            "My wife’s cooking is so bad we usually pray after our food.",
            "Marriage is an institution of three rings. Engagement ring, wedding ring and suffering.",
            "Pregnant women are the only true body builders.",
            "My head is very slowly 3D printing my hair.",
            "I and Bill Gates have a combined fortune of approximately 80 billion dollars.",
            "If you’re waiting to be served in a restaurant, shouldn’t you be called the waiter?",
            "Has a giraffe ever smelled its own fart?",
            "Babysitters are teenagers who behave like grown-ups so that grown-ups can go out and behave like teenagers.",
            "A cold seat in a public restroom is unpleasant. But a warm seat in a public restroom is worse.",
            "Dentist: \"You need a crown.\" Patient: \"Finally someone who understands me!\"",
            "What do you call the soft tissue between a shark's teeth? A slow swimmer."
        };

        [HttpGet]
        public string GetRandomJoke()
        {
            var rnd = new Random((int)DateTime.Now.Ticks);
            var idx = rnd.Next(s_Jokes.Length);
            return s_Jokes[idx];
        }
    }
}