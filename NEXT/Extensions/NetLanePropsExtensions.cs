﻿using System.Linq;
using UnityEngine;

namespace QuadTrainTrack.NEXT.Extensions
{
    public static class NetLanePropsExtensions
    {
        public static NetLaneProps Clone(this NetLaneProps nLP, string newName = null)
        {
            var newNLP = ScriptableObject.CreateInstance<NetLaneProps>();

            if (newName != null)
            {
                newNLP.name = newName;
            }
            else
            {
                if (nLP != null)
                {
                    newNLP.name = nLP.name;
                }
            }

            if (nLP == null || nLP.m_props == null)
            {
                newNLP.m_props = new NetLaneProps.Prop[0];
            }
            else
            {
                newNLP.m_props = nLP.m_props.Where(p => p != null).Select(p => p.ShallowClone()).ToArray();
            }

            return newNLP;
        }
    }
}
