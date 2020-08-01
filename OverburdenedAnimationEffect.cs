using System;
using XRL.Core;

namespace XRL.World.Effects
{
  public class OverburdenedAnimationEffect : Effect
  {
  	public OverburdenedAnimationEffect() {
  		this.DisplayName = "overburdened animation";
  		this.Duration = 1;
  	}

  	public override bool Apply(GameObject Object)
    {
	  if (Object.HasEffect(nameof (OverburdenedAnimationEffect))) {
	  	return false;
	  }
      return true;
    }

    public virtual bool SuppressInLookDisplay()
    {
      return true;
    }

    public override bool Render(RenderEvent E)
    {
      int num = XRLCore.CurrentFrame % 60;
      if (num > 50 && num < 60)
      {
        E.Tile = (string) null;
        E.RenderString = "O";
        E.ColorString = "&R";
      }
      return true;
    }
  }
}