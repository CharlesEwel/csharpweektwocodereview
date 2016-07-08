
using Nancy;
using System;
using System.Collections.Generic;

namespace RepeatCounter.Objects
{
  public class RepeatCounter
  {
    public int CountRepeats(string inputString, string inputWord)
    {
      int numberOfRepeats=0;
      char[] stringArray = inputString.ToCharArray();
      char[] wordArray = inputWord.ToCharArray();
      bool matches = true;
      for(int i=0; i<stringArray.Length; i++)
      {
        if(stringArray[i] != wordArray[i])
        {
          matches=false;
        }
      }
      if(matches)
      {
        numberOfRepeats+=1;
      }
      return numberOfRepeats;
    }
  }
}
