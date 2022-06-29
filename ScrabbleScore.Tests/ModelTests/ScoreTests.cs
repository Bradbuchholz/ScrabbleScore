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
    public void ScrabbleScore_CreatesAWordObject_ScrabbleScore()
    {
      Score newScrabbleScore = new Score();
      Assert.AreEqual(typeof(Score), newScrabbleScore.GetType());
    }
  }
}