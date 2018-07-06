using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace TunisianArabic.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WordContext(
                serviceProvider.GetRequiredService<DbContextOptions<WordContext>>()))
            {
                // Look for any movies.
                if (context.Word.Any())
                {
                    return;   // DB has been seeded
                }

                context.Word.AddRange(
                    new Word
                    {
                        TunWord = "aaslama",
                        EngWord = "Hello",
                        ArabWord = "مرحبا",
                        Pronunciation = "aas la ma ",
                        Description = "Hello is Tunisian accent ",
                        Nature = " greeting ",
                        FbTypping = "3aslama",
                        Score = 5,
                        PicURL = ""

                    },
                       new Word
                       {
                           TunWord = "salem",
                           EngWord = "Hello",
                           ArabWord = "السلام",
                           Pronunciation = "salem ",
                           Description = "Hello is Tunisian accent schort for assalamou alaikom ",
                           Nature = " greeting ",
                           FbTypping = "slm",
                           Score = 5,
                           PicURL = ""

                       },
                          new Word
                          {
                              TunWord = "marhbé",
                              EngWord = "Hello",
                              ArabWord = "مرحبا",
                              Pronunciation = "salem ",
                              Description = "marhbe is welcome in the Tunisian accent  ",
                              Nature = " greeting ",
                              FbTypping = "mar7be",
                              Score = 5,
                              PicURL = ""

                          },

                      new Word
                      {
                          TunWord = "Beslama",
                          EngWord = "Bye",
                          ArabWord = "الى اللقاء",
                          Pronunciation = "bes la ma ",
                          Description = "good bye is Tunisian accent ",
                          Nature = " greeting ",
                          FbTypping = "beslama",
                          Score = 5,
                          PicURL = ""

                      },
                         new Word
                         {
                             TunWord = "tesbeh ala khir",
                             EngWord = "good night",
                             ArabWord = "تصبح على خير",
                             Pronunciation = "tes bah aala khir  prounse the kha sound as if something is stuck in your throwt  ",
                             Description = " Good night is Tunisian accent ",
                             Nature = " greeting ",
                             FbTypping = "tesbe7 3la 5ir",
                             Score = 5,
                             PicURL = ""
                         },
                             new Word
                             {
                                 TunWord = "sbah el khir",
                                 EngWord = "good morning",
                                 ArabWord = "صباح  خير",
                                 Pronunciation = "sbah el khir  prounse the kha sound as if something is stuck in your throwt  ",
                                 Description = " Good morning is Tunisian accent ",
                                 Nature = " greeting ",
                                 FbTypping = "sba7 el 5ir",
                                 Score = 5,
                                 PicURL = ""
                             },
                                new Word
                                {
                                    TunWord = "mekla",
                                    EngWord = "food",
                                    ArabWord = "أكل",
                                    Pronunciation = " me k la   ",
                                    Description = " food in tunisian accent  ",
                                    Nature = " food ",
                                    FbTypping = "mekla",
                                    Score = 5,
                                    PicURL = "https://cdn2.webmanagercenter.com/di/wp-content/uploads/2015/06/plat_ramadan.jpg"
                                },
                                   new Word
                                   {
                                       TunWord = "khoboz",
                                       EngWord = "bread",
                                       ArabWord = "خبز",
                                       Pronunciation = " kho  be  zz   ",
                                       Description = " bread in tunisian accent  ",
                                       Nature = " food ",
                                       FbTypping = "5bez",
                                       Score = 5,
                                       PicURL = "https://i.ytimg.com/vi/Rl21b_kZCc8/maxresdefault.jpg"
                                   },
                                   new Word
                                   {
                                       TunWord = "tabouna",
                                       EngWord = "bread",
                                       ArabWord = "خبز طابونة",
                                       Pronunciation = " ta bou na  ",
                                       Description = " tradional bread in tunisian ",
                                       Nature = " food ",
                                       FbTypping = "tabouna",
                                       Score = 5,
                                       PicURL = "http://www.wepostmag.com/wp-content/uploads/2016/06/6a278722943ab7c2c7e8cc20839127b3.jpg"
                                   },
                                   new Word
                                   {
                                       TunWord = "metabgha",
                                       EngWord = "bread",
                                       ArabWord = "خبز مطبقة",
                                       Pronunciation = " met ta b gha  as in    ",
                                       Description = " tradional bread in the south of tunisian also known as kesra bechham",
                                       Nature = " food ",
                                       FbTypping = "metab9a",
                                       Score = 5,
                                       PicURL = "http://3.bp.blogspot.com/-P2RTIQmryDg/UKeZjD4V_pI/AAAAAAAABEM/98Yij4e9mA8/s1600/DSC_2831.JPG"
                                   },
                                   new Word
                                   {
                                       TunWord = "hrisa",
                                       EngWord = "hrisa",
                                       ArabWord = "هريسة",
                                       Pronunciation = " ha ri ssa ",
                                       Description = "a famous chilli sousse in tunisia that is used a lot in our food especiaallly with making sandwiches ",
                                       Nature = " food ",
                                       FbTypping = "hrisa",
                                       Score = 5,
                                       PicURL = "http://fouara.dz/images/2017/10/24/hrissa.png"
                                   },
                                   new Word
                                   {
                                       TunWord = "asidet zghoughou",
                                       EngWord = "asidet zghoughou",
                                       ArabWord = "عصيدة زقوقو",
                                       Pronunciation = " aa  si da zghou ghou ",
                                       Description = "Tunisian dessert often prepared to celebrate the Mūled made with the grains of Aleppo pines  ",
                                       Nature = " food ",
                                       FbTypping = "z9ou9ou",
                                       Score = 5,
                                       PicURL = "https://i.pinimg.com/474x/32/6a/fa/326afa693f1643a06782fe9e1b68757a--populaire-trifle.jpg"
                                   },
                                   new Word
                                   {
                                       TunWord = "glace",
                                       EngWord = "ice cream",
                                       ArabWord = "مثلاجات",
                                       Pronunciation = " glass ",
                                       Description = "ice cream in tunisian it come from crème glacée in french  ",
                                       Nature = " food ",
                                       FbTypping = "glace",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "maa",
                                       EngWord = "water",
                                       ArabWord = "ماء",
                                       Pronunciation = " ma ea ",
                                       Description = "water in tunisian accent  ",
                                       Nature = " drink",
                                       FbTypping = "ma2",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "couscous",
                                       EngWord = "couscous",
                                       ArabWord = "كسكس",
                                       Pronunciation = "cous cous  ",
                                       Description = "the best tradional food in tunisia and north african countries  ",
                                       Nature = " food ",
                                       FbTypping = "coscos",
                                       Score = 5,
                                       PicURL = "https://sites.google.com/site/couscousenligne/_/rsrc/1340567479151/couscous-tunisien-traditionnel/couscous%20tunisien.jpg"
                                   },
                                   new Word
                                   {
                                       TunWord = "ghazouz",
                                       EngWord = "soda",
                                       ArabWord = "مشروب غازي",
                                       Pronunciation = "ga zouz",
                                       Description = "soda in tunisian accent  ",
                                       Nature = " drink",
                                       FbTypping = "9azouz",
                                       Score = 5,
                                       PicURL = "http://www.bahadourian.com/images/produits/zoom/2154i.jpg"
                                   },
                                   new Word
                                   {
                                       TunWord = "makarouna",
                                       EngWord = "pasta",
                                       ArabWord = "مقرونة",
                                       Pronunciation = "ma ka () rou na   ",
                                       Description = "pasta in tunisianaccent  ",
                                       Nature = " food ",
                                       FbTypping = "ma9rouna",
                                       Score = 5,
                                       PicURL = "http://img.over-blog-kiwi.com/0/13/53/61/201304/ob_ea4a8f2287cc2a7916494a167ae00665_makrouna-bel-salsa.JPG"
                                   },
                                   new Word
                                   {
                                       TunWord = "halwa",
                                       EngWord = "candy",
                                       ArabWord = "حلوى",
                                       Pronunciation = "hal wa ",
                                       Description = "candy in tunisianaccent  ",
                                       Nature = " food ",
                                       FbTypping = "7alwa",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "kahwa",
                                       EngWord = "coofee",
                                       ArabWord = "قهوة",
                                       Pronunciation = "kah wa ",
                                       Description = "coofee in tunisianaccent  ",
                                       Nature = "drink ",
                                       FbTypping = "9ahwa",
                                       Score = 5,
                                       PicURL = "https://natashapavlovadotcom.files.wordpress.com/2017/05/465a8605.jpg?w=662"
                                   },
                                   new Word
                                   {
                                       TunWord = "youyou",
                                       EngWord = "youyou",
                                       ArabWord = "يويو",
                                       Pronunciation = " you you ",
                                       Description = "a  tunisian sweet that looks like donuts ",
                                       Nature = " food ",
                                       FbTypping = "youyou",
                                       Score = 5,
                                       PicURL = "https://i.ytimg.com/vi/VOzzgUis-Yc/maxresdefault.jpg"
                                   },
                                   new Word
                                   {
                                       TunWord = "bach koutou ",
                                       EngWord = "Biscuit",
                                       ArabWord = "بسكويت",
                                       Pronunciation = " bas kou tou  ",
                                       Description = " Biscuit in tunisia ",
                                       Nature = " food ",
                                       FbTypping = "biscuit or bachkoutou",
                                       Score = 5,
                                       PicURL = "http://p1.storage.canalblog.com/16/54/290051/16802028.jpg"
                                   },
                                   new Word
                                   {
                                       TunWord = "kabout",
                                       EngWord = "coat",
                                       ArabWord = "معطف",
                                       Pronunciation = "ka bou if you're prouncing it like k about you are wrong    ",
                                       Description = " winter coat in tunisian accent ",
                                       Nature = "clothes",
                                       FbTypping = "kabout",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "barnouce",
                                       EngWord = "tradional man coat",
                                       ArabWord = "برنوص",
                                       Pronunciation = "bar nouce ",
                                       Description = "tradionnal  winter coat for men in tunisian ",
                                       Nature = "clothes",
                                       FbTypping = "barnouce",
                                       Score = 5,
                                       PicURL = "https://i.pinimg.com/736x/f0/ac/2a/f0ac2aedbb503c82b736ea687e2e0438.jpg"
                                   },
                                   new Word
                                   {
                                       TunWord = "bonnet",
                                       EngWord = "Beanie",
                                       ArabWord = "",
                                       Pronunciation = "bo nne the t is silent",
                                       Description = "beanie in tunisian  accent ",
                                       Nature = "clothes",
                                       FbTypping = "bonnet",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "sabat",
                                       EngWord = "shoe",
                                       ArabWord = "حذاء",
                                       Pronunciation = "sab aat ",
                                       Description = "shoe in tunisian  accent ",
                                       Nature = "clothes",
                                       FbTypping = "sabat",
                                       Score = 5,
                                       PicURL = "https://m.media-amazon.com/images/G/01/6pm/landing/2017/shoes/october/mensboots._CB1507922868_.jpg"
                                   },
                                   new Word
                                   {
                                       TunWord = "chlaka",
                                       EngWord = "slipper",
                                       ArabWord = "",
                                       Pronunciation = "ech la ka ",
                                       Description = "flip flop or slipper in tunisian  accent ",
                                       Nature = "clothes",
                                       FbTypping = "bonnet",
                                       Score = 5,
                                       PicURL = "https://s3-eu-west-1.amazonaws.com/images.linnlive.com/86159574884c75271b8a5a8544bc49e5/836fda62-64c4-4ebb-8ed5-2ced58c7a7b3.jpg"
                                   },
                                   new Word
                                   {
                                       TunWord = "souriya",
                                       EngWord = "shirt",
                                       ArabWord = "قميص",
                                       Pronunciation = "like syria but with ou instead of y (we use chemise too )",
                                       Description = "shirt in tunisian  accent ",
                                       Nature = "clothes",
                                       FbTypping = "soriya / chemise",
                                       Score = 5,
                                       PicURL = "https://www.pendleton-usa.com/dw/image/v2/BBNP_PRD/on/demandware.static/-/Sites-pwm-master-catalog/default/dw17a0e19b/images/large/50004_9586.jpg?sw=378&sh=474&sm=fit"
                                   },
                                   new Word
                                   {
                                       TunWord = "serwel",
                                       EngWord = "pants",
                                       ArabWord = "سروال",
                                       Pronunciation = "sir well",
                                       Description = "pants in tunisian  accent ",
                                       Nature = "clothes",
                                       FbTypping = "serwel",
                                       Score = 5,
                                       PicURL = ""
                                   },

                                   new Word
                                   {
                                       TunWord = "meryoul",
                                       EngWord = "Tee-shirt",
                                       ArabWord = "قميص",
                                       Pronunciation = "sir well",
                                       Description = " tee-shirt in tunisian  accent  ",
                                       Nature = "clothes",
                                       FbTypping = "meryoul",
                                       Score = 5,
                                       PicURL = "http://scene7.zumiez.com/is/image/zumiez/pdp_hero/Zine-2nd-Inning-Heather-Grey-%26-Marled-Red-Baseball-Shirt-_225749-front.jpg"
                                   }
,
                                   new Word
                                   {
                                       TunWord = "klast",
                                       EngWord = "socks",
                                       ArabWord = "جوارب",
                                       Pronunciation = "kla set",
                                       Description = " socks in tunisian  accent  ",
                                       Nature = "clothes",
                                       FbTypping = "9laset",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "cousina",
                                       EngWord = "kitchen",
                                       ArabWord = "مطبخ",
                                       Pronunciation = "co oui si na ",
                                       Description = "kichen in tunisian  accent  ",
                                       Nature = "house",
                                       FbTypping = "cousina",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "kess",
                                       EngWord = "cup",
                                       ArabWord = "كأس",
                                       Pronunciation = " ke ss",
                                       Description = "cup in tunisian  accent  ",
                                       Nature = "kitchen supplies",
                                       FbTypping = "kes",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "shan",
                                       EngWord = "plate",
                                       ArabWord = "صحن",
                                       Pronunciation = "es han ",
                                       Description = "plate in tunisian  accent  ",
                                       Nature = "kitchen supplies",
                                       FbTypping = "s7an",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "mgharfa",
                                       EngWord = "spoon",
                                       ArabWord = "ملعقة",
                                       Pronunciation = " em ghar fa ",
                                       Description = "spoon in tunisian  accent  ",
                                       Nature = "kitchen supplies",
                                       FbTypping = "m8arfa",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "forchita",
                                       EngWord = "fork",
                                       ArabWord = "شوكة",
                                       Pronunciation = " for chi ta ",
                                       Description = " fork in tunisian  accent  ",
                                       Nature = "kitchen supplies",
                                       FbTypping = "forchita",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "sekina",
                                       EngWord = "knife",
                                       ArabWord = "سكين",
                                       Pronunciation = " sekkin na  ",
                                       Description = "knife in tunisian  accent  ",
                                       Nature = "kitchen supplies",
                                       FbTypping = "sekina",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "bared",
                                       EngWord = "tea pot",
                                       ArabWord = "براد",
                                       Pronunciation = "ba red ",
                                       Description = "tea pot in tunisian  accent  ",
                                       Nature = "kitchen supplies",
                                       FbTypping = "bared",
                                       Score = 5,
                                       PicURL = "https://i.pinimg.com/736x/6d/b6/67/6db667a99b81c6ff60e5e76b1a98feb3--mint-tea-cuppa-tea.jpg"

                                   },
                                   new Word
                                   {
                                       TunWord = "marmita",
                                       EngWord = "cooking pot",
                                       ArabWord = "وعاء الطبخ",
                                       Pronunciation = "mar mi tta",
                                       Description = "cooking pot in tunisian  accent  ",
                                       Nature = "kitchen supplies",
                                       FbTypping = "marmita",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "bit",
                                       EngWord = " room",
                                       ArabWord = "غرفة",
                                       Pronunciation = "beat ",
                                       Description = "room in tunisian  accent  ",
                                       Nature = "house",
                                       FbTypping = "bit",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "bit noum",
                                       EngWord = "bedroom",
                                       ArabWord = "غرفة نوم",
                                       Pronunciation = "beat noom",
                                       Description = "bedroom in tunisian  accent  ",
                                       Nature = "house",
                                       FbTypping = "bit noom ",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "salla",
                                       EngWord = "living room",
                                       ArabWord = "غرفة المعيشة",
                                       Pronunciation = " sa lla ",
                                       Description = "living room in tunisian  accent / salon in french ",
                                       Nature = "house",
                                       FbTypping = "salla ",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "bit ftour",
                                       EngWord = " dining room",
                                       ArabWord = "غرفة الاكل",
                                       Pronunciation = "beat el ftour  ",
                                       Description = "dining room in tunisian  accent  ",
                                       Nature = "house",
                                       FbTypping = "bit el ftour ",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "jnina",
                                       EngWord = " Garden",
                                       ArabWord = "حديقة",
                                       Pronunciation = "jni ni ",
                                       Description = "garden in tunisian  accent / you can jarda as well ",
                                       Nature = "house",
                                       FbTypping = "jnina",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "garage",
                                       EngWord = " garage",
                                       ArabWord = "كراج",
                                       Pronunciation = "jni ni ",
                                       Description = "garage in tunisian  accent",
                                       Nature = "house",
                                       FbTypping = "garage",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "dar",
                                       EngWord = "house",
                                       ArabWord = "دار",
                                       Pronunciation = "dar ",
                                       Description = "house in tunisian  accent",
                                       Nature = "house",
                                       FbTypping = "dar",
                                       Score = 5,
                                       PicURL = "https://ssl.c.photoshelter.com/img-get/I0000oUrCjMy0wjQ/s/900/900/Sidi-Bou-Said-735-04.jpg"
                                   },
                                   new Word
                                   {
                                       TunWord = "jbal",
                                       EngWord = "mountain",
                                       ArabWord = "جبل",
                                       Pronunciation = "j bell",
                                       Description = "house in tunisian  accent",
                                       Nature = "Nature",
                                       FbTypping = "jbal",
                                       Score = 5,
                                       PicURL = "http://mw2.google.com/mw-panoramio/photos/medium/64165741.jpg"
                                   },
                                   new Word
                                   {
                                       TunWord = "ghaba",
                                       EngWord = "forest",
                                       ArabWord = "غابة",
                                       Pronunciation = "ghaba",
                                       Description = "forest in tunisian  accent",
                                       Nature = "Nature",
                                       FbTypping = "ghaba",
                                       Score = 5,
                                       PicURL = "http://www.mes-locations.com/img/1421863131-129830.jpg"
                                   },

                                   new Word
                                   {
                                       TunWord = "bhar",
                                       EngWord = "sea",
                                       ArabWord = "بحر",
                                       Pronunciation = "b har",
                                       Description = "sea in tunisian  accent",
                                       Nature = "Nature",
                                       FbTypping = "b7ar",
                                       Score = 5,
                                       PicURL = "https://i.pinimg.com/236x/61/8f/12/618f127685c742ed89d155fb1cfde5e5--tunis-oceans.jpg"
                                   },
                                   new Word
                                   {
                                       TunWord = "mouja",
                                       EngWord = "wave",
                                       ArabWord = "موجة",
                                       Pronunciation = "mou jja",
                                       Description = "wave in tunisian  accent",
                                       Nature = "Nature",
                                       FbTypping = "mouja",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "shallal",
                                       EngWord = "waterfall",
                                       ArabWord = "شلال",
                                       Pronunciation = "chall lell",
                                       Description = "waterfall in tunisian  accent",
                                       Nature = "Nature",
                                       FbTypping = "shallal",
                                       Score = 5,
                                       PicURL = "https://previews.123rf.com/images/letyg84/letyg841301/letyg84130100169/17510082-Natural-waterfall-of-Oasis-of-Nefta-Chebika-Tunisia-Stock-Photo.jpg"
                                   },
                                   new Word
                                   {
                                       TunWord = "fac",
                                       EngWord = "College/University",
                                       ArabWord = "جامعة",
                                       Pronunciation = "fac",
                                       Description = "sorry if the word sound like a bad word but it's actually short for facultè in french = college",
                                       Nature = "School",
                                       FbTypping = "fac",
                                       Score = 5,
                                       PicURL = "http://www.utunis.rnu.tn/tbs/images/demo/gallery/572x330-6.png"
                                   },
                                   new Word
                                   {
                                       TunWord = "college",
                                       EngWord = "middle school",
                                       ArabWord = "المدرسة المتوسطة",
                                       Pronunciation = "coleege",
                                       Description = "a school intermediate between an elementary school and a high school, typically for children in the seventh, eighth and nigheth grades",
                                       Nature = "School",
                                       FbTypping = "college",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "lycée",
                                       EngWord = " High school",
                                       ArabWord = "المدرسة الثانوية",
                                       Pronunciation = "lye cee",
                                       Description = " a school that typically comprises grades 10 through 14 (bac), attended after primary school or middle school",
                                       Nature = "School",
                                       FbTypping = "lycee",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "mardersa",
                                       EngWord = " primary school",
                                       ArabWord = "المدرسة الابتدائية",
                                       Pronunciation = "mad rr ssa ",
                                       Description = " a school that typically comprises grades 1 through 6",
                                       Nature = "School",
                                       FbTypping = "madresa",
                                       Score = 5,
                                       PicURL = ""
                                   },
                                   new Word
                                   {
                                       TunWord = "rawtha",
                                       EngWord = " kindergarten",
                                       ArabWord = "روضة",
                                       Pronunciation = "raw dtha ",
                                       Description = " a school or class that prepares children for first grade. A child in kindergarten is typically between 3 & 5 years old",
                                       Nature = "School",
                                       FbTypping = "rawtha",
                                       Score = 5,
                                       PicURL = ""
                                   }








                );
                context.SaveChanges();
            }
        }
    }
}
