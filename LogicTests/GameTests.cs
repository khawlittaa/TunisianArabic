using System;
using Xunit;
using LogicClasses;
namespace LogicTests
{
    public class GameTests
    {
        SpeakingGame game;

        // initialisation before every test 
        public GameTests()
        {
            game = new SpeakingGame();
        }
        [Fact]
        public void TestEnd()
        {
            game = new SpeakingGame(0, 0);
           Assert.Equal(false, game.End);
            int max = game.Size;
            game.Index = game.Size;
            Assert.Equal(game.Index,max);
          string last = game.CurrentWord(max);
            Assert.Equal("Game Over", last);
            Assert.True(game.CheckEnd());

        }

        [Fact]
        public void TestWord()
        {
            Assert.Equal("keedeech oomreek ? ",game.CurrentWord(2));

        }
        [Fact]
        public void TestExplain()
        {
            Assert.Equal("what time is it ?", game.CurrentExplain(3));

        }
        [Fact]
        public void TestConstec()
        {
            game = new SpeakingGame(4, 40);
            Assert.Equal(4, game.Index);
            Assert.Equal(40, game.Score);
            Assert.Equal("do you speek english ?", game.CurrentExplain(game.Index));

        }

        

    }
}
