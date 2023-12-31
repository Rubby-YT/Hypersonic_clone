using MelonLoader;
using BTD_Mod_Helper;
using Hypersonic_clone;
using Il2CppAssets.Scripts.Models;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Weapons;

[assembly: MelonInfo(typeof(Hypersonic_clone.Hypersonic_clone), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace Hypersonic_clone;

public class Hypersonic_clone : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<Hypersonic_clone>("Hypersonic_clone loaded!");

    }
    public override void OnNewGameModel(GameModel result)
    {
       foreach(var weapon in result.GetDescendants<WeaponModel>().ToList())
        {
            weapon.rate = 0;
        }
    }
}