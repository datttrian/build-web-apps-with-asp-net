// Storm.cs
using System;

namespace MagicalInheritance
{
  class Storm : Spell
  {
    // private string Essence
    // { get; set; }

    // public bool IsStrong
    // { get; private set; }

    // public string Caster
    // { get; private set; }

    // Storm s = new Storm("wind", false, "Your name")
    public Storm(string essence, bool isStrong, string caster)
    {
      Essence = essence;
      IsStrong = isStrong;
      Caster = caster;
    }

    public override string Announce()
    {
      if(IsStrong == true)
      {
        return $"{Caster} cast a strong {Essence} storm!";
      }
      else
      {
        return $"{Caster} cast a weak {Essence} storm!";
      }
    }
  }
}
