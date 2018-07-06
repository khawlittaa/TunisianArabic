
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using LogicClasses;

namespace TunisianArabic.Pages
{
    public class GameModel : PageModel
    {
        SpeakingGame game;
        static string SCORE = "Score";
     //   static string Current_SENT = "sentences";
     //   static string MEANNING = "meanning";
        static string INDEX = "Index";


        public int Score { get; set; }
        public string TunWord { get; set; }
        public string Meanning { get; set; }
        public int Index { get; set; }

        public void OnGet()
        {
            game = new SpeakingGame();
            TunWord = game.Word;
            Meanning = game.Trans;

             HttpContext.Session.Clear();
        }

        //public void OnPost()
        //{

        //}

        public IActionResult OnPostNext()
        {
             Score = HttpContext.Session.GetInt32(SCORE) ?? 0;
             Index = HttpContext.Session.GetInt32(INDEX) ?? 0;

            Index = 1+Index;
            Score = Score + 10;
            game = new SpeakingGame(Index, Score);
            if(game.CurrentWord(Index)!= "Game Over")
            {
                Meanning = game.CurrentExplain(Index);
                TunWord = game.CurrentWord(game.Index);
                
            }
            if (Score >= 100)
            {
                Meanning = "end of the Game";
                TunWord = "el loaabaa wfet";
                Score = 100;
            }
            

            HttpContext.Session.SetInt32(INDEX, game.Index);
            HttpContext.Session.SetInt32(SCORE, game.Score);

            return Page();
        }

        //private void Save()
        //{
        //}
        //private void Retieve()
        //{

        //    game = new SpeakingGame(Index, Score);
        //}

    }
}