using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleScore.Models;
using System;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class Score
  {
    [TestMethod]
    public void Score_CreatesAWordObject_Score()
    {
      Score newScore = new Score();
      Assert.AreEqual(typeof(Score), newScore.GetType());
    }
  }
}