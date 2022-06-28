using System.Collections.Generic;
using System;

namespace ScrableScore.Models {

  public static class ScrableScore
  {

    private static Dictionary<string, int> LetterScore = new Dictionary<string, int> 
    {
      {"A, E, I, O, U, L, N, R, S, T"} = 1,
      {"D, G"} = 2,
      {"B, C, M, P"} = 3,
      {"F, H, V, W, Y"} = 4,
      {"K"} = 5,
      {"J, X"} = 8,
      {"Q, Z"} = 10
    };


  }
}