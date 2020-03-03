using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class TranslatorTests
  {
    [TestMethod]
    public void IsLetter_OutputIsLetter_True()
    {
      Translator testTranslator = new Translator();
      Assert.AreEqual(true, testTranslator.IsLetter("a"));
    }

    [TestMethod]
    public void CharacterReplace_WasReplacedWith3_True()
    {
      Translator testTranslator = new Translator();
      Assert.AreEqual("3", testTranslator.CharacterReplace("e"));
    }

    [TestMethod]
    public void CharacterReplace_WasReplacedWith0_True()
    {
      Translator testTranslator = new Translator();
      Assert.AreEqual("0", testTranslator.CharacterReplace("o"));
    }

    [TestMethod]
    public void CharacterReplace_WasReplacedWith1_True()
    {
      Translator testTranslator = new Translator();
      Assert.AreEqual("1", testTranslator.CharacterReplace("I"));
    }

    [TestMethod]
    public void CharacterReplace_WasReplacedWith7_True()
    {
      Translator testTranslator = new Translator();
      Assert.AreEqual("7", testTranslator.CharacterReplace("t"));
    }

    [TestMethod]
    public void CharacterReplace_WasReplacedWithZUlessFirstLetter_True()
    {
      Translator testTranslator = new Translator();
      Assert.AreEqual("z", testTranslator.CharacterReplace("s"));
    }

    [TestMethod]
    public void ToAnArray_TurnStringIntoAnArray_True()
    {
    Translator testTranslator = new Translator();
    CollectionAssert.AreEqual(new string[] {"w","o","r","d"}, testTranslator.ToAnArray("word"));
    }
  }
}