using MelonLoader;
using BTD_Mod_Helper;
using TUTORIALMOD;
using Il2CppAssets.Scripts.Models;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Weapons;

[assembly: MelonInfo(typeof(TUTORIALMOD.TUTORIALMOD), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace TUTORIALMOD;

public class TUTORIALMOD : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<TUTORIALMOD>("TUTORIALMOD loaded!");

    }
    public override void OnNewGameModel(GameModel result)
    {
       foreach(var weapon in result.GetDescendants<WeaponModel>().ToList())
        {
            weapon.rate = 0;
        }
    }
}