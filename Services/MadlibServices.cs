using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne_Endpoint.Models;
namespace AllForOne_Endpoint.Services
{
    public class MadlibServices
    {
        public List<MadlibStory> story = [];

        public string GenerateStory(MadlibStory story)
        {

            string storyStr = $"Dear {story.Noun1}, I cannot come to school today because I feel so {story.Adjective2}. Last night I ate{story.Number3} {story.Noun4} and drank a litre of {story.Noun5}. Today I woke up feeling absolutely {story.Adjective6} and looking like a {story.Noun7}. Anyway, please give me {story.Number8} pieces of homework as I don’t think I will be back at school for at least {story.Number9} years.See you when I am old and{story.Adjective10}. Yours {story.Adverb11}, {story.Noun12}.";

            return storyStr;
        }

    }
}