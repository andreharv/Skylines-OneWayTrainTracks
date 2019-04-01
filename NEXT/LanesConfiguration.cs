﻿
namespace QuadTrainTrack.NEXT
{
    public class LanesConfiguration
    {
        public int LanesToAdd { get; set; }
        public float PedLaneOffset { get; set; }
        public float? PedPropOffsetX { get; set; }
        public float? SpeedLimit { get; set; }
        public float LaneWidth { get; set; }
        public bool IsTwoWay { get; set; }
        public bool HasBusStop { get; set; }
        public float BusStopOffset { get; set; }
        public CenterLaneType CenterLane { get; set; }
        public float CenterLaneWidth { get; set; }

        public LanesConfiguration()
        {
            LanesToAdd = 0;
            PedLaneOffset = 0.0f;
            PedPropOffsetX = null;
            SpeedLimit = null;
            LaneWidth = 3.0f;
            IsTwoWay = true;
            HasBusStop = true;
            BusStopOffset = 1.5f;
            CenterLane = CenterLaneType.None;
            CenterLaneWidth = 3.0f;
        }
    }
}
