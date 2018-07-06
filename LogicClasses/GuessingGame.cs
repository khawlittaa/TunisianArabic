//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.EntityFrameworkCore;
//using TunisianArabic.Models;
//using Microsoft.AspNetCore.Mvc.Rendering;
//namespace LogicClasses
//{
//    public class GuessingGame
//    {
//        private readonly TunisianArabic.Models.WordContext _context;

//        private List<Word> allWords;
//        private int score;
//        private int remainingWords;
//        private string currentWord;

//        // public string WordDescription { get; set; }

//        public int Score {get ; set;}

//        public GuessingGame()
//        {
//            score = 0;
//            List<Word> Words = (from w in _context.Word
//                        select w).ToList<Word>();
//            allWords = Words.GetRange(1, 20);

//        }

//        public GuessingGame(int cscore)
//        {
//            score = cscore;
//            allWords = (from w in _context.Word
//                       select w).ToList<Word>();

//        }

//        public void ResetGame()
//        {
//            remainingWords = 20;
//            score = 0;
//            allWords = (from w in _context.Word
//                        select w).ToList<Word>();
//        }

//        public string Randomword()
//        {
//            currentWord = allWords.ElementAt(remainingWords).TunWord;
//            return currentWord;
//        }

//        public string wordDescription()
//        {
             
//            return allWords.ElementAt(remainingWords).Description;
//        }

//        public bool checkAnswer(string answer)
//        {
//            if (answer == currentWord)
//            {
//                score += 5;
//                return true; }
//            else
//                return false;
//        }

    

       
//    }
//}
