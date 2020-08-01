using HarmonyLib;
using XRL.World.Effects;
using XRL.World.Parts;
using XRL.World;
using XRL.Core;

[HarmonyPatch(typeof(Inventory))]
[HarmonyPatch("CheckOverburdened")]
public class InventoryCheckOverburdenedPatch {
  static void Postfix(Inventory __instance, ref bool __result) {
  	if (__result && !__instance.ParentObject.HasEffectByClass("OverburdenedAnimationEffect")) {
  		__instance.ParentObject.ApplyEffect((Effect) new OverburdenedAnimationEffect());
  	} else {
  		__instance.ParentObject.RemoveEffectByExactClass("OverburdenedAnimationEffect");
  	}
  }
}