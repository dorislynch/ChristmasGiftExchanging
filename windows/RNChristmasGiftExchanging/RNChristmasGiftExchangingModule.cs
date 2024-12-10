using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Christmas.Gift.Exchanging.RNChristmasGiftExchanging
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNChristmasGiftExchangingModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNChristmasGiftExchangingModule"/>.
        /// </summary>
        internal RNChristmasGiftExchangingModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNChristmasGiftExchanging";
            }
        }
    }
}
