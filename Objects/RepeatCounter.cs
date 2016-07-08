
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
      for(int i=0; i<=(stringArray.Length - wordArray.Length); i++)
      {
        if(stringArray[i] == wordArray[0])
        {
          bool matches = true;
          for(int j=1; j<wordArray.Length; j++)
          {
            if(stringArray[i+j] != wordArray[j])
            {
              matches=false;
            }
          }
          if(matches)
          {
            numberOfRepeats+=1;
          }
        }
      }
      return numberOfRepeats;
    }
  }
}
