using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using OpenAI_API;
using OpenAI_API.Completions;
namespace BookStoreMVCWeb.Controllers
{
    public class ChatGPTController : Controller
    {
        [HttpGet]
        public IActionResult UseChatGpt()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>UseChatGpt(string Text)
        {
            var openAI = new OpenAIAPI("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");
            string answer = string.Empty;
            CompletionRequest completion = new CompletionRequest();
            completion.Prompt = Text;
            completion.Model = OpenAI_API.Models.Model.DavinciText;
            completion.MaxTokens = 200;
            var result = openAI.Completions.CreateCompletionAsync(completion);
            foreach(var item in result.Result.Completions)
            {
                answer = item.Text;            
            }
			ViewBag.Answer = answer;
			return View("UseChatGpt");
        }
        
    }
}
