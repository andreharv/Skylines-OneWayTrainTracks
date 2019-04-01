using System;
using System.Collections.Generic;
using System.Linq;
using ColossalFramework.UI;
using ICities;
using QuadTrainTrack.NEXT;
using UnityEngine;
using Object = UnityEngine.Object;

namespace QuadTrainTrack
{
    public class LoadingExtension : LoadingExtensionBase
    {
        public static bool Done { get; private set; } // Only one Assets installation throughout the application

        private static void InstallAssets()
        {
            if (Done) // Only one Assets installation throughout the application
            {
                return;
            }
            var path = Util.AssemblyPath;
            foreach (var action in AssetManager.instance.CreateLoadingSequence(path))
            {
                var localAction = action;

                Loading.QueueLoadingAction(() =>
                {
                    try
                    {
                        localAction();
                    }
                    catch (Exception ex)
                    {
                        UnityEngine.Debug.LogException(ex);
                    }
                });
            }
            Done = true;
        }

        public override void OnLevelLoaded(LoadMode mode)
        {
            base.OnLevelLoaded(mode);
            ModifyExistingNetInfos.ModifyExistingTrainTracks();
        }

        public override void OnReleased()
        {
            base.OnReleased();
            ModifyExistingNetInfos.Reset();
        }
    }
}