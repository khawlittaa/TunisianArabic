using System;
using System.Collections.Generic;
using System.Text;

namespace LogicClasses
{
    public class SpeakingGame
    {
        private bool end = false;
        private int index ;
        private int score ;
        String[] sentences = { "aaslama", "chnouwa esmek ?", "keedeech oomreek ? ","keedeech el wakeet ?"," taaref tehki anglais ?","bkeedech ?",
                "lmekla bnina","kess tey mnaaneaa(mne3ne3)","kifech nemchi ll matar ?","mezyana","good bye"               };
        string[] meanning = { "hello", "what is ur name ?", "how old are you ?" ,"what time is it ?","do you speek english ?","how much ?",
            "the food is delicious","a minty cup of tea","how can i go to the airport ?","beautiful","beslama"
                              };
        public int Size {
            get {
                return sentences.Length;
            } }
        public int Score { get {return score; } set{score = value; } }
        public int Index { get { return index; } set {index = value; } }
        public bool End { get {return end; } set {end = value; } }

        public  string Word {
            get { return sentences[index]; }
             }
        public string Trans
        {
            get { return meanning[index]; }
        }

        public SpeakingGame()
        {
            index = 0;
            score = 0;
            end = false;
        }
        public SpeakingGame(int Gindex, int Gscore)
        {
            index = Gindex;
            score = Gscore;
            end = CheckEnd ();
        }

        public bool CheckEnd()
        {
            if (index >= sentences.Length )
                //|| score >= 100)
            {
                end = true;
                return true;
            }
            else
            {
                end = false;
                return false;
        }
        }

        public string CurrentWord(int index)
        {
            if (!CheckEnd())
                return sentences[index];
            else return "Game Over";
        }

        public string CurrentExplain(int index)
        {
            if (!CheckEnd())
                return meanning[index];
            else return "Game Over";
        }

    }
}
