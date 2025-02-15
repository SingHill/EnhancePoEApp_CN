﻿using ChaosRecipeEnhancer.UI.Model;
using ChaosRecipeEnhancer.UI.Properties;

namespace ChaosRecipeEnhancer.UI.Factory.Managers.Implementation
{
    internal class CBootsManager : ABaseItemClassManager
    {
        #region Constructors

        public CBootsManager()
        {
            ClassName = "Boots";
            ClassFilterName = "\"Boots\"";
            ClassColor = Settings.Default.ColorBoots;
            AlwaysActive = Settings.Default.BootsAlwaysActive;
        }

        #endregion

        #region Methods

        public override ActiveItemTypes SetActiveTypes(ActiveItemTypes activeItems, bool newValue)
        {
            activeItems.BootsActive = newValue;
            return activeItems;
        }

        #endregion
    }
}