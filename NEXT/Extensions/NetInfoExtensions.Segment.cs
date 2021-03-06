﻿using SingleTrainTrack.NEXT.Texturing;
using System.Collections.Generic;
using UnityEngine;

namespace SingleTrainTrack.NEXT.Extensions
{
    public static partial class NetInfoExtensions
    {
        public static NetInfo SetAllSegmentsTexture(this NetInfo info, TextureSet newTextures, LODTextureSet newLODTextures = null)
        {
            foreach (var segment in info.m_segments)
            {
                segment.SetTextures(newTextures, newLODTextures);
            }

            return info;
        }

        public static NetInfo.Segment SetTextures(this NetInfo.Segment segment, TextureSet newTextures, LODTextureSet newLODTextures = null)
        {
            if (newTextures != null)
            {
                if (segment.m_material != null)
                {
                    segment.m_material = newTextures.CreateRoadMaterial(segment.m_material);
                }
            }

            if (newLODTextures != null)
            {
                if (segment.m_lodMaterial != null)
                {
                    segment.m_lodMaterial = newLODTextures.CreateRoadMaterial(segment.m_lodMaterial);
                }
            }

            return segment;
        }

        public static NetInfo.Segment SetMeshes(this NetInfo.Segment segment, string newMeshPath, string newLODMeshPath = null)
        {
            segment.m_mesh = AssetManager.instance.GetMesh(newMeshPath);

            if (newLODMeshPath != null)
            {
                segment.m_lodMesh = AssetManager.instance.GetMesh(newLODMeshPath);
            }

            return segment;
        }


        public static NetInfo.Segment SetFlagsDefault(this NetInfo.Segment segment)
        {
            segment.m_backwardForbidden = NetSegment.Flags.None;
            segment.m_backwardRequired = NetSegment.Flags.None;

            segment.m_forwardForbidden = NetSegment.Flags.None;
            segment.m_forwardRequired = NetSegment.Flags.None;

            return segment;
        }

        public static NetInfo.Segment SetConsistentUVs(this NetInfo.Segment segment, bool isPowerLines = true)
        {
            var colors = new List<Color>();
            var colors32 = new List<Color32>();
            Color color;
            Color32 color32;
            if (isPowerLines)
            {
                color = new Color(0, 0, 0, 255);
                color32 = new Color32(0, 0, 0, 255);
            }
            else
            {
                color = new Color(255, 0, 255, 255);
                color32 = new Color32(255, 0, 255, 255);
            }

            for (int i = 0; i < segment.m_mesh.vertexCount; i++)
            {
                colors.Add(color);
                colors32.Add(color32);
            }
            segment.m_mesh.colors = colors.ToArray();
            segment.m_mesh.colors32 = colors32.ToArray();

            colors = new List<Color>();
            colors32 = new List<Color32>();
            for (int i = 0; i < segment.m_lodMesh.vertexCount; i++)
            {
                colors.Add(color);
                colors32.Add(color32);
            }
            segment.m_lodMesh.colors = colors.ToArray();
            segment.m_lodMesh.colors32 = colors32.ToArray();

            return segment;
        }
    }
}
