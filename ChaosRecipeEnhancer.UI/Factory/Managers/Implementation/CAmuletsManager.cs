﻿using ChaosRecipeEnhancer.UI.Model;
using ChaosRecipeEnhancer.UI.Properties;

namespace ChaosRecipeEnhancer.UI.Factory.Managers.Implementation
{
    internal class CAmuletsManager : ABaseItemClassManager
    {
        #region Constructors

        public CAmuletsManager()
        {
            ClassName = "Amulets";
            ClassFilterName = "\"Amulets\"";
            ClassColor = Settings.Default.ColorAmulet;
            AlwaysActive = Settings.Default.AmuletsAlwaysActive;
        }

        #endregion

        #region Methods

        public override ActiveItemTypes SetActiveTypes(ActiveItemTypes activeItems, bool newValue)
        {
            activeItems.AmuletActive = newValue;
            return activeItems;
        }

        #endregion
    }
}