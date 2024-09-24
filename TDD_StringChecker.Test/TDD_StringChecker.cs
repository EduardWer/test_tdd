using System;
using NUnit.Framework;
using TDD_StringCheck;

namespace TDD_StringChecker.Test
{
    [TestFixture]
    public class TDD_StringChecker
    {
        [Test]
        public void shortword_hello_word_wordexepted()
        {

            string str = "hello word";

            TDD_StringCheckers stringChecker = new TDD_StringCheckers();

            StringAssert.IsMatch(stringChecker.shortwords(str), "word");
        }


        [Test]
        public void wordLeight_hello_word_2exepted() // колво слов в строке 
        {
            string str = "hello word";

            TDD_StringCheckers stringChecker = new TDD_StringCheckers();

            Assert.AreEqual(stringChecker.wordLeight(str), 2);
        }

        [Test]
        public void wordCount_hello_word_10exepted()
        {
            string str = "hello word";

            TDD_StringCheckers stringChecker = new TDD_StringCheckers();

            Assert.AreEqual(stringChecker.wordCount(str), 10);
        }


        [Test]
        public void wordNight_hello_word_rexepted()
        {
            string str = "hello word";

            TDD_StringCheckers stringChecker = new TDD_StringCheckers();

            Assert.AreEqual(stringChecker.wordNight(str), 'r');
        }


        [Test]
        public void ints_hjdfkgh12345hddfgk_5exepted()
        {
            string str = "hjdfkgh12345hddfgk";

            TDD_StringCheckers stringChecker = new TDD_StringCheckers();

            Assert.AreEqual(stringChecker.ints(str), 5);
        }



        [Test]
        public void ints_podrad_edsd123sdfsf_3exepted()
        {
            string str = "edsd123sdfsf";


            TDD_StringCheckers stringChecker = new TDD_StringCheckers();

            Assert.AreEqual(stringChecker.ints_count(str), 3);
        }


        [Test]
        public void search_am_hfdkjghkamdfam_2exepted()
        {
            string str = "hfdkjghkamdfam";
            string substring = "am";
            TDD_StringCheckers stringChecker = new TDD_StringCheckers();

            Assert.AreEqual(stringChecker.search_am(str,substring), 2);
        }
    }


}