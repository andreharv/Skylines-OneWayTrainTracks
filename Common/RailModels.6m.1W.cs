﻿using System;
using System.Collections.Generic;
using SingleTrainTrack.NEXT;
using SingleTrainTrack.NEXT.Extensions;
using SingleTrainTrack.NEXT.Texturing;

namespace SingleTrainTrack.Common
{
    public static partial class RailModels
    {

        public static void Setup6m1WMesh(this NetInfo info, NetInfoVersion version)
        {
            ///////////////////////////
            // Template              //
            ///////////////////////////
            var ttInfo = Prefabs.Find<NetInfo>(Mod.TRAIN_TRACK);
            var defaultMaterial = ttInfo.m_nodes[0].m_material;

            switch (version)
            {
                case NetInfoVersion.Ground:
                    {
                        var segments0 = info.m_segments[0];
                        var segments1 = info.m_segments[1];
                        var segments2 = info.m_segments[2];
                        var nodes0 = info.m_nodes[0];
                        var nodes1 = info.m_nodes[1];
                        var nodes2 = info.m_nodes[2];
                        var nodes3 = info.m_nodes[3];
                        var nodes4 = info.m_nodes[1].ShallowClone();
                        var nodes5 = info.m_nodes[1].ShallowClone();
                        var nodes6 = info.m_nodes[3].ShallowClone();
                        var nodes7 = info.m_nodes[3].ShallowClone();

                        nodes1.m_connectGroup = NetInfo.ConnectGroup.SingleTrain | NetInfo.ConnectGroup.Oneway;
                        nodes3.m_connectGroup = NetInfo.ConnectGroup.SingleTrain | NetInfo.ConnectGroup.Oneway;
                        nodes4.m_connectGroup = NetInfo.ConnectGroup.DoubleTrain | NetInfo.ConnectGroup.OnewayStart;
                        nodes5.m_connectGroup = NetInfo.ConnectGroup.DoubleTrain | NetInfo.ConnectGroup.OnewayEnd;
                        nodes6.m_connectGroup = NetInfo.ConnectGroup.DoubleTrain | NetInfo.ConnectGroup.OnewayStart;
                        nodes7.m_connectGroup = NetInfo.ConnectGroup.DoubleTrain | NetInfo.ConnectGroup.OnewayEnd;

                        segments0
                            .SetFlagsDefault()
                            .SetMeshes
                            (@"Meshes\6m\Ground_Pavement.obj",
                            @"Meshes\6m\Ground_Pavement_LOD.obj");

                        segments1
                            .SetFlagsDefault()
                            .SetMeshes
                            (@"Meshes\6m\Ground_Rail.obj",
                            @"Meshes\6m\Ground_Rail_LOD.obj");

                        segments2
                            .SetMeshes
                            (@"Meshes\6m\Ground_Power.obj",
                            @"Meshes\6m\Ground_Power.obj")
                            .SetConsistentUVs();

                        nodes0
                            .SetMeshes
                            (@"Meshes\6m\Ground_Pavement_Node.obj",
                            @"Meshes\6m\Ground_Pavement_Node_LOD.obj");

                        nodes1
                            .SetMeshes
                            (@"Meshes\6m\Ground_Rail.obj",
                            @"Meshes\6m\Ground_Rail_Node_LOD.obj");

                        nodes2
                            .SetMeshes
                            (@"Meshes\6m\Ground_Level_Crossing.obj",
                            @"Meshes\6m\Ground_Level_Crossing_LOD.obj");


                        nodes3
                            .SetMeshes
                            (@"Meshes\6m\Ground_Power.obj",
                            @"Meshes\6m\Ground_Power.obj")
                            .SetConsistentUVs();
                        nodes4
                            .SetMeshes
                            (@"Meshes\6m\Ground_Rail_Start.obj",
                            @"Meshes\6m\Ground_Rail_Start_LOD.obj");
                        nodes5
                            .SetMeshes
                            (@"Meshes\6m\Ground_Rail_End.obj",
                            @"Meshes\6m\Ground_Rail_End_LOD.obj");
                        nodes6
                            .SetMeshes
                            (@"Meshes\6m\Ground_Power_Start.obj",
                            @"Meshes\6m\Ground_Power_Start.obj")
                            .SetConsistentUVs();
                        nodes7
                            .SetMeshes
                            (@"Meshes\6m\Ground_Power_End.obj",
                            @"Meshes\6m\Ground_Power_End.obj")
                            .SetConsistentUVs();

                        info.m_segments = new[] { segments0, segments1, segments2 };
                        info.m_nodes = new[] { nodes0, nodes1, nodes2, nodes3, nodes4, nodes5, nodes6, nodes7 };
                        break;
                    }

                case NetInfoVersion.Elevated:
                    {
                        var segments0 = info.m_segments[0];
                        var segments1 = info.m_segments[1];
                        var segments2 = info.m_segments[2];
                        var nodes0 = info.m_nodes[0];
                        var nodes1 = info.m_nodes[1];
                        var nodes2 = info.m_nodes[2];
                        var nodes3 = info.m_nodes[3];
                        var nodes4 = info.m_nodes[1].ShallowClone();
                        var nodes5 = info.m_nodes[1].ShallowClone();
                        var nodes6 = info.m_nodes[2].ShallowClone();
                        var nodes7 = info.m_nodes[2].ShallowClone();

                        nodes1.m_connectGroup = NetInfo.ConnectGroup.SingleTrain | NetInfo.ConnectGroup.Oneway;
                        nodes2.m_connectGroup = NetInfo.ConnectGroup.SingleTrain | NetInfo.ConnectGroup.Oneway;
                        nodes4.m_connectGroup = NetInfo.ConnectGroup.DoubleTrain | NetInfo.ConnectGroup.OnewayStart;
                        nodes5.m_connectGroup = NetInfo.ConnectGroup.DoubleTrain | NetInfo.ConnectGroup.OnewayEnd;
                        nodes6.m_connectGroup = NetInfo.ConnectGroup.DoubleTrain | NetInfo.ConnectGroup.OnewayStart;
                        nodes7.m_connectGroup = NetInfo.ConnectGroup.DoubleTrain | NetInfo.ConnectGroup.OnewayEnd;

                        segments0
                            .SetFlagsDefault()
                            .SetMeshes
                            (@"Meshes\6m\Elevated_Pavement.obj",
                            @"Meshes\6m\Elevated_Pavement_LOD.obj");

                        segments1
                            .SetFlagsDefault()
                            .SetMeshes
                            (@"Meshes\6m\Ground_Rail.obj",
                            @"Meshes\6m\Ground_Rail_LOD.obj");

                        segments2
                            .SetMeshes
                            (@"Meshes\6m\Ground_Power.obj",
                            @"Meshes\6m\Ground_Power.obj")
                            .SetConsistentUVs();

                        nodes0
                            .SetMeshes
                            (@"Meshes\6m\Elevated_Pavement.obj",
                            @"Meshes\6m\Elevated_Pavement_Node_LOD.obj");

                        nodes1
                            .SetMeshes
                            (@"Meshes\6m\Ground_Rail.obj",
                            @"Meshes\6m\Ground_Rail_Node_LOD.obj");
                        nodes2
                            .SetMeshes
                            (@"Meshes\6m\Ground_Power.obj",
                            @"Meshes\6m\Ground_Power.obj")
                            .SetConsistentUVs();
                        nodes4
                            .SetMeshes
                            (@"Meshes\6m\Ground_Rail_Start.obj",
                            @"Meshes\6m\Ground_Rail_Start_LOD.obj");
                        nodes5
                            .SetMeshes
                            (@"Meshes\6m\Ground_Rail_End.obj",
                            @"Meshes\6m\Ground_Rail_End_LOD.obj");
                        nodes6
                            .SetMeshes
                            (@"Meshes\6m\Ground_Power_Start.obj",
                            @"Meshes\6m\Ground_Power_Start.obj")
                            .SetConsistentUVs();
                        nodes7
                            .SetMeshes
                            (@"Meshes\6m\Ground_Power_End.obj",
                            @"Meshes\6m\Ground_Power_End.obj")
                            .SetConsistentUVs();

                        info.m_segments = new[] { segments0, segments1, segments2 };
                        info.m_nodes = new[] { nodes0, nodes1, nodes2, nodes3, nodes4, nodes5, nodes6, nodes7 };
                        break;
                    }
                case NetInfoVersion.Bridge:
                    {
                        var segments0 = info.m_segments[0];
                        var segments1 = info.m_segments[1];
                        var segments2 = info.m_segments[2];
                        var nodes0 = info.m_nodes[0];
                        var nodes1 = info.m_nodes[1];
                        var nodes2 = info.m_nodes[2];
                        var nodes3 = info.m_nodes[3];
                        var nodes4 = info.m_nodes[1].ShallowClone();
                        var nodes5 = info.m_nodes[1].ShallowClone();
                        var nodes6 = info.m_nodes[2].ShallowClone();
                        var nodes7 = info.m_nodes[2].ShallowClone();

                        nodes1.m_connectGroup = NetInfo.ConnectGroup.SingleTrain | NetInfo.ConnectGroup.Oneway;
                        nodes2.m_connectGroup = NetInfo.ConnectGroup.SingleTrain | NetInfo.ConnectGroup.Oneway;
                        nodes4.m_connectGroup = NetInfo.ConnectGroup.DoubleTrain | NetInfo.ConnectGroup.OnewayStart;
                        nodes5.m_connectGroup = NetInfo.ConnectGroup.DoubleTrain | NetInfo.ConnectGroup.OnewayEnd;
                        nodes6.m_connectGroup = NetInfo.ConnectGroup.DoubleTrain | NetInfo.ConnectGroup.OnewayStart;
                        nodes7.m_connectGroup = NetInfo.ConnectGroup.DoubleTrain | NetInfo.ConnectGroup.OnewayEnd;

                        segments0
                            .SetFlagsDefault()
                            .SetMeshes
                            (@"Meshes\6m\Bridge_Pavement.obj",
                            @"Meshes\6m\Bridge_Pavement_LOD.obj");

                        segments1
                            .SetFlagsDefault()
                            .SetMeshes
                            (@"Meshes\6m\Ground_Rail.obj",
                            @"Meshes\6m\Ground_Rail_LOD.obj");

                        segments2
                            .SetMeshes
                            (@"Meshes\6m\Ground_Power.obj",
                            @"Meshes\6m\Ground_Power.obj")
                            .SetConsistentUVs();

                        nodes0
                            .SetMeshes
                            (@"Meshes\6m\Elevated_Pavement.obj",
                            @"Meshes\6m\Elevated_Pavement_Node_LOD.obj");

                        nodes1
                            .SetMeshes
                            (@"Meshes\6m\Ground_Rail.obj",
                            @"Meshes\6m\Ground_Rail_Node_LOD.obj");
                        nodes2
                            .SetMeshes
                            (@"Meshes\6m\Ground_Power.obj",
                            @"Meshes\6m\Ground_Power.obj")
                            .SetConsistentUVs();
                        nodes4
                            .SetMeshes
                            (@"Meshes\6m\Ground_Rail_Start.obj",
                            @"Meshes\6m\Ground_Rail_Start_LOD.obj");
                        nodes5
                            .SetMeshes
                            (@"Meshes\6m\Ground_Rail_End.obj",
                            @"Meshes\6m\Ground_Rail_End_LOD.obj");
                        nodes6
                            .SetMeshes
                            (@"Meshes\6m\Ground_Power_Start.obj",
                            @"Meshes\6m\Ground_Power_Start.obj")
                            .SetConsistentUVs();
                        nodes7
                            .SetMeshes
                            (@"Meshes\6m\Ground_Power_End.obj",
                            @"Meshes\6m\Ground_Power_End.obj")
                            .SetConsistentUVs();

                        var segmentNormals = segments0.m_mesh.normals;
                        var segmentVertices = segments0.m_mesh.vertices;
                        var colors = new List<UnityEngine.Color>();
                        var colors32 = new List<UnityEngine.Color32>();

                        for (int i = 0; i < segments0.m_mesh.vertexCount; i++)
                        {
                            if (segmentNormals[i].y == 1 && segmentVertices[i].y == 0)
                            {
                                colors.Add(new UnityEngine.Color(255, 255, 255, 255));
                                colors32.Add(new UnityEngine.Color32(255, 255, 255, 255));
                            }
                            else
                            {
                                colors.Add(new UnityEngine.Color(255, 0, 255, 255));
                                colors32.Add(new UnityEngine.Color32(255, 0, 255, 255));
                            }
                        }
                        segments0.m_mesh.colors = colors.ToArray();
                        segments0.m_mesh.colors32 = colors32.ToArray();

                        segmentNormals = segments0.m_lodMesh.normals;
                        segmentVertices = segments0.m_lodMesh.vertices;
                        colors = new List<UnityEngine.Color>();
                        colors32 = new List<UnityEngine.Color32>();

                        for (int i = 0; i < segments0.m_lodMesh.vertexCount; i++)
                        {
                            if (segmentNormals[i].y == 1 && Math.Abs(segmentVertices[i].x) <= 3 && segmentVertices[i].y < 3)
                            {
                                colors.Add(new UnityEngine.Color(255, 255, 255, 255));
                                colors32.Add(new UnityEngine.Color32(255, 255, 255, 255));
                            }
                            else
                            {
                                colors.Add(new UnityEngine.Color(255, 0, 255, 255));
                                colors32.Add(new UnityEngine.Color32(255, 0, 255, 255));
                            }
                        }
                        segments0.m_lodMesh.colors = colors.ToArray();
                        segments0.m_lodMesh.colors32 = colors32.ToArray();

                        info.m_segments = new[] { segments0, segments1, segments2 };
                        info.m_nodes = new[] { nodes0, nodes1, nodes2, nodes3, nodes4, nodes5, nodes6, nodes7 };
                        break;
                    }

                case NetInfoVersion.Slope:
                    {
                        var pedSlope = Prefabs.Find<NetInfo>("Pedestrian Slope");
                        var segments0 = info.m_segments[0];
                        var segments1 = info.m_segments[1];
                        var segments2 = info.m_segments[2];
                        var segments3 = pedSlope.m_segments[0].ShallowClone();
                        var segments4 = ttInfo.m_segments[0].ShallowClone();
                        var nodes0 = info.m_nodes[0];
                        var nodes1 = info.m_nodes[1];
                        var nodes2 = info.m_nodes[2];
                        var nodes3 = info.m_nodes[3];
                        var nodes4 = info.m_nodes[4];
                        var nodes5 = info.m_nodes[1].ShallowClone();
                        var nodes6 = info.m_nodes[1].ShallowClone();
                        var nodes7 = info.m_nodes[2].ShallowClone();
                        var nodes8 = info.m_nodes[2].ShallowClone();

                        nodes1.m_connectGroup = NetInfo.ConnectGroup.SingleTrain | NetInfo.ConnectGroup.Oneway;
                        nodes2.m_connectGroup = NetInfo.ConnectGroup.SingleTrain | NetInfo.ConnectGroup.Oneway;
                        nodes5.m_connectGroup = NetInfo.ConnectGroup.DoubleTrain | NetInfo.ConnectGroup.OnewayStart;
                        nodes6.m_connectGroup = NetInfo.ConnectGroup.DoubleTrain | NetInfo.ConnectGroup.OnewayEnd;
                        nodes7.m_connectGroup = NetInfo.ConnectGroup.DoubleTrain | NetInfo.ConnectGroup.OnewayStart;
                        nodes8.m_connectGroup = NetInfo.ConnectGroup.DoubleTrain | NetInfo.ConnectGroup.OnewayEnd;

                        segments0
                            .SetMeshes
                            (@"Meshes\6m\Tunnel.obj",
                            @"Meshes\6m\Tunnel_Node_LOD.obj");
                        segments1
                            .SetFlagsDefault()
                            .SetMeshes
                            (@"Meshes\6m\Ground_Rail.obj",
                            @"Meshes\6m\Ground_Rail_LOD.obj");

                        segments2
                            .SetMeshes
                            (@"Meshes\6m\Ground_Power.obj",
                            @"Meshes\6m\Ground_Power.obj")
                            .SetConsistentUVs();
                        segments4
                            .SetMeshes
                            (@"Meshes\6m\Ground_Pavement.obj",
                            @"Meshes\6m\Ground_Pavement_LOD.obj");

                        nodes0
                            .SetMeshes
                            (@"Meshes\6m\Tunnel_Node.obj",
                            @"Meshes\6m\Tunnel_Node_LOD.obj");

                        nodes1
                            .SetMeshes
                            (@"Meshes\6m\Ground_Rail.obj",
                            @"Meshes\6m\Ground_Rail_Node_LOD.obj");
                        nodes2
                            .SetMeshes
                            (@"Meshes\6m\Ground_Power.obj",
                            @"Meshes\6m\Ground_Power.obj")
                            .SetConsistentUVs();
                        nodes3
                            .SetMeshes
                            (@"Meshes\6m\Ground_Pavement_Node.obj",
                            @"Meshes\6m\Ground_Pavement_Node_LOD.obj");
                        nodes5
                            .SetMeshes
                            (@"Meshes\6m\Ground_Rail_Start.obj",
                            @"Meshes\6m\Ground_Rail_Start_LOD.obj");
                        nodes6
                            .SetMeshes
                            (@"Meshes\6m\Ground_Rail_End.obj",
                            @"Meshes\6m\Ground_Rail_End_LOD.obj");
                        nodes7
                            .SetMeshes
                            (@"Meshes\6m\Ground_Power_Start.obj",
                            @"Meshes\6m\Ground_Power_Start.obj")
                            .SetConsistentUVs();
                        nodes8
                            .SetMeshes
                            (@"Meshes\6m\Ground_Power_End.obj",
                            @"Meshes\6m\Ground_Power_End.obj")
                            .SetConsistentUVs();

                        var colors = new List<UnityEngine.Color>();
                        var colors32 = new List<UnityEngine.Color32>();
                        var tangents = new List<UnityEngine.Vector4>();

                        for (int i = 0; i < segments2.m_mesh.vertexCount; i++)
                        {
                            colors.Add(new UnityEngine.Color(0, 0, 0, 255));
                            colors32.Add(new UnityEngine.Color32(0, 0, 0, 255));
                            tangents.Add(new UnityEngine.Vector4(0, 0, 1, -1));
                        }

                        segments2.m_mesh.colors = colors.ToArray();
                        segments2.m_mesh.colors32 = colors32.ToArray();
                        segments2.m_mesh.tangents = tangents.ToArray();

                        nodes2.m_mesh.colors = colors.ToArray();
                        nodes2.m_mesh.colors32 = colors32.ToArray();
                        nodes2.m_mesh.tangents = tangents.ToArray();

                        nodes7.m_mesh.colors = colors.ToArray();
                        nodes7.m_mesh.colors32 = colors32.ToArray();
                        nodes7.m_mesh.tangents = tangents.ToArray();

                        nodes8.m_mesh.colors = colors.ToArray();
                        nodes8.m_mesh.colors32 = colors32.ToArray();
                        nodes8.m_mesh.tangents = tangents.ToArray();

                        info.m_segments = new[] { segments0, segments1, segments2, segments3, segments4 };
                        info.m_nodes = new[] { nodes0, nodes1, nodes2, nodes3, nodes4, nodes5, nodes6, nodes7, nodes8 };
                        break;
                    }
                case NetInfoVersion.Tunnel:
                    {
                        var segments0 = info.m_segments[0];
                        var nodes0 = info.m_nodes[0];

                        segments0
                            .SetMeshes
                            (@"Meshes\6m\Tunnel.obj",
                            @"Meshes\6m\Tunnel_Node_LOD.obj");

                        nodes0
                            .SetMeshes
                            (@"Meshes\6m\Tunnel_Node.obj",
                            @"Meshes\6m\Tunnel_Node_LOD.obj");

                        info.m_segments = new[] { segments0 };
                        info.m_nodes = new[] { nodes0 };
                    }
                    break;
            }
        }

        public static void Setup6m1WTextures(this NetInfo info, NetInfoVersion version)
        {
            switch (version)
            {
                case NetInfoVersion.Ground:
                    for (var i = 0; i < info.m_segments.Length; i++)
                    {
                        if (info.m_segments[i].m_mesh.name.Contains("Ground_Pavement"))
                        {
                            info.m_segments[i].SetTextures(
                                new TextureSet
                                (@"Textures\Rail1LStation\Ground_Segment_Pavement__MainTex.png",
                                    @"Textures\Rail1LStation\Ground_Segment_Pavement__AlphaMap.png"));
                        }
                    }
                    break;
                case NetInfoVersion.Slope:
                    for (var i = 0; i < info.m_segments.Length; i++)
                    {
                        if (info.m_segments[i].m_mesh.name == "pedestrian-tunnel-slope")
                        {
                            info.m_segments[i].SetTextures(
                                new TextureSet
                                (@"Textures\Rail1LStation\Slope_Segment__MainTex.png",
                                    @"Textures\Rail1LStation\Slope_Segment__AlphaMap.png"),
                                new LODTextureSet
                                (@"Textures\Rail1LStation\Slope_Cover_LOD__MainTex.png",
                                    @"Textures\Rail1LStation\Slope_Cover_LOD__AlphaMap.png",
                                    @"Textures\Rail1LStation\Slope_Cover_LOD__XYSMap.png"));
                        }
                        else if (info.m_segments[i].m_mesh.name.Contains("Ground_Pavement"))
                        {
                            info.m_segments[i].SetTextures(
                                new TextureSet
                                (@"Textures\Rail1LStation\Ground_Segment_Pavement__MainTex.png",
                                    @"Textures\Rail1LStation\Ground_Segment_Pavement__AlphaMap.png",
                                    null));
                        }
                    }
                    break;
                case NetInfoVersion.Tunnel:
                {
                    info.SetAllSegmentsTexture(
                        new TextureSet
                        (@"Textures\Rail1LStation\Tunnel_Segment__MainTex.png",
                            @"Textures\Rail1LStation\Tunnel_Segment__AlphaMap.png"));
                    info.SetAllNodesTexture(
                        new TextureSet
                        (@"Textures\Rail1LStation\Tunnel_Segment__MainTex.png",
                            @"Textures\Rail1LStation\Tunnel_Segment__AlphaMap.png"));
                    break;
                }
            }
        }
    }
}
