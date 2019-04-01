using ColossalFramework.UI;
using QuadTrainTrack.NEXT;
using QuadTrainTrack.NEXT.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace QuadTrainTrack {
    class ModifyExistingNetInfos {
        private static bool modified;
        public static void ModifyExistingTrainTracks() {

            if (modified) {
                return;
            }
            var railInfos = Resources.FindObjectsOfTypeAll<NetInfo>();
            var targetRailInfos = railInfos.Where(ri =>
                ri?.m_netAI is TrainTrackBaseAI &&
                ri.m_class.m_subService == ItemClass.SubService.PublicTransportTrain &&
                ri.m_minCornerOffset < 18);
            foreach (var railInfo in targetRailInfos) {
                railInfo.m_minCornerOffset = 18;
                modified = true;
            }
        }

        public static void Reset() {
            modified = false;
        }
    }
}
