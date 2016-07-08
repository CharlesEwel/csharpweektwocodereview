
using Nancy;
using System;
using System.Collections.Generic;

namespace RepeatCount.Objects
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
            bool isStartOfWord = (i==0) || !unapprovedSurrounders.Contains(Char.ToLower(stringArray[i-1]));
            bool isEndOfWord = ((i+wordArray.Length)==stringArray.Length) || !unapprovedSurrounders.Contains(Char.ToLower(stringArray[i+wordArray.Length]));
            if(isStartOfWord && matches && isEndOfWord)
            {
              numberOfRepeats+=1;
            }
          }
        }
        return numberOfRepeats;
      }
    }
    public string DisplayNumberOfRepeats(int repeats)
    {
      if(repeats==-1)
      {
        return "Sorry, but your search term was invalid. It may consist only of letters and numbers (this means no spaces). Please try again.";
      }
      else
      {
        return "There were " + repeats + " matches for your search term in the given string.";
      }
    }
  }
}
