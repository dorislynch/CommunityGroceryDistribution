using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Community.Grocery.Distribution.RNCommunityGroceryDistribution
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCommunityGroceryDistributionModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCommunityGroceryDistributionModule"/>.
        /// </summary>
        internal RNCommunityGroceryDistributionModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCommunityGroceryDistribution";
            }
        }
    }
}
