
using Nancy;
using System;
using System.Collections.Generic;

namespace RepeatCounter.Objects
{
  public class RepeatCounter
  {
    public int CountRepeats(string inputString, string inputWord)
    {
      List<char> unapprovedSurrounders = new List<char> {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0' ,'1', '2', '3', '4', '5', '6', '7', '8', '9'};
      int numberOfRepeats=0;
      char[] stringArray = inputString.ToCharArray();
      char[] wordArray = (inputWord).ToCharArray();
      bool isWordValid=true;
      for(int i=0; i<wordArray.Length; i++)
      {
        if(!unapprovedSurrounders.Contains(Char.ToLower(wordArray[i])))
        {
          isWordValid=false;
        }
      }
      if(!isWordValid)
      {
        return -1;
      }
      else
      {
        bool isStartOfWord = true;
        for(int i=0; i<=(stringArray.Length - wordArray.Length); i++)
        {
          if(isStartOfWord && stringArray[i] == wordArray[0])
          {
            bool matches = true;
            for(int j=1; j<wordArray.Length; j++)
            {
              if(stringArray[i+j] != wordArray[j])
              {
                matches=false;
              }
            }
            bool isEndOfWord = ((i+wordArray.Length)==stringArray.Length) || !unapprovedSurrounders.Contains(Char.ToLower(stringArray[i+wordArray.Length]));
            if(matches && isEndOfWord)
            {
              numberOfRepeats+=1;
            }
          }
          if(unapprovedSurrounders.Contains(Char.ToLower(stringArray[i])))
          {
            isStartOfWord=false;
          }
          else if(stringArray[i]==' ')
          {
            isStartOfWord=true;
          }
        }
        return numberOfRepeats;
      }  
    }
  }
}
