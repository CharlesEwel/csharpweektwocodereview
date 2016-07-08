using Xunit;
namespace RepeatCounter.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_TotalMismatch_0()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      Assert.Equal(0, newRepeatCounter.CountRepeats("the cat in the cathedral", "dog"));
    }
    // [Fact]
    // public void CountRepeats_ExactMatch_1()
    // {
    //   RepeatCounter newRepeatCounter = new RepeatCounter();
    //   Assert.Equal(1, newRepeatCounter.CountRepeats("cat", "cat"));
    // }
    // [Fact]
    // public void CountRepeats_AllMatches_2()
    // {
    //   RepeatCounter newRepeatCounter = new RepeatCounter();
    //   Assert.Equal(2, newRepeatCounter.CountRepeats("the cat in the cathedral", "cat"));
    // }
    //For the test immediately below, I was concerned that my set-up would incorrectly include partials of my search word if they fell at the very end of the string. That turned out not to be the case and this test passed right away. So it's not really a 'spec' per se, at least as I understand a spec, so it's not mentioned in the readme, but I wanted to include some explanation of the test. The sample input is so chosen because in some incorrect set-ups the 'ca' at the end of 'casablanca' could incorrectly match with 'cat'
    [Fact]
    public void CountRepeats_MatchChunkAtEnd_0()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      Assert.Equal(0, newRepeatCounter.CountRepeats("casablanca", "cat"));
    }
    [Fact]
    public void CountRepeats_SpacedFullMatches_1()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      Assert.Equal(1, newRepeatCounter.CountRepeats("the scatter cat cathedral building", "cat"));
    }
    // [Fact]
    // public void CountRepeats_PunctuatedFullMatches_2()
    // {
    //   RepeatCounter newRepeatCounter = new RepeatCounter();
    //   Assert.Equal(2, newRepeatCounter.CountRepeats("the 'cat' cat.", "cat"));
    // }
    // [Fact]
    // public void CountRepeats_AllFullMatches_3()
    // {
    //   RepeatCounter newRepeatCounter = new RepeatCounter();
    //   Assert.Equal(2, newRepeatCounter.CountRepeats("cat by the cat", "cat"));
    // }
  }
}
