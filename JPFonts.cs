using ReLogic.Content;
using ReLogic.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JPFonts
{
    public class JPFonts : Mod
	{
        internal static JPFonts Instance;
        public JPFonts()
        {
            Instance = this;
        }
        public override void Load()
        {
            //LoadFonts(true);
        }
        public override void Unload()
        {
            LoadFonts(false);
            Instance = null;
        }
        public override void PostSetupContent()
        {
            LoadFonts(true);
        }
        internal void LoadFonts(bool use)
        {
            AssetRequestMode mode = AssetRequestMode.ImmediateLoad;
            if (use)
            {
                FontAssets.ItemStack = Request<DynamicSpriteFont>("JPFonts/Fonts/Item_Stack", mode);
                FontAssets.MouseText = Request<DynamicSpriteFont>("JPFonts/Fonts/Mouse_Text", mode);
                FontAssets.DeathText = Request<DynamicSpriteFont>("JPFonts/Fonts/Death_Text", mode);
                FontAssets.CombatText[0] = Request<DynamicSpriteFont>("JPFonts/Fonts/Combat_Text", mode);
                FontAssets.CombatText[1] = Request<DynamicSpriteFont>("JPFonts/Fonts/Combat_Crit", mode);
                return;
            }
            FontAssets.ItemStack = Request<DynamicSpriteFont>("Terraria/Fonts/Item_Stack", mode);
            FontAssets.MouseText = Request<DynamicSpriteFont>("Terraria/Fonts/Mouse_Text", mode);
            FontAssets.DeathText = Request<DynamicSpriteFont>("Terraria/Fonts/Death_Text", mode);
            FontAssets.CombatText[0] = Request<DynamicSpriteFont>("Terraria/Fonts/Combat_Text", mode);
            FontAssets.CombatText[1] = Request<DynamicSpriteFont>("Terraria/Fonts/Combat_Crit", mode);
        }
    }
}