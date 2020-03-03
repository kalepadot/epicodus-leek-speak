namespace LeetSpeak
{
  public class Translator
  {
    public bool IsLetter(string inputLetter)
    {
      return true;
    }
    public string CharacterReplace(string inputLetter)
    {
      if (inputLetter == "e")
      {
        string outputThree = "3";
        return outputThree;
      }
      else if (inputLetter == "o")
      {
        string outputZero = "0";
        return outputZero;
      }
      else if (inputLetter == "I")
      {
        string outputOne = "1";
        return outputOne;
      }
      else if (inputLetter == "t")
      {
        string outputSeven = "7";
        return outputSeven;
      }
      else if (inputLetter == "s")
      {
        string outputS = "z";
        return outputS;
      }
      else
      {
        return inputLetter;
      }
    }
    
    public object ToAnArray(string inputString)
    {
      char[] inputArray = inputString.ToCharArray();
      return inputArray;
    }
  }
}
