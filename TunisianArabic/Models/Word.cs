using System;
using System.ComponentModel.DataAnnotations;

namespace TunisianArabic.Models
{
    public class Word
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string TunWord { get; set; }
        [Required]
        public string EngWord { get; set; }
        public string ArabWord { get; set; }
        public string Pronunciation { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Description { get; set; }
        [Required]
        public string Nature { get; set; }
        public string  FbTypping {get; set;}
        [Required]
        [Range(1,20)]
        public int Score { get; set; }
        public string PicURL { get; set; }
    }
}
