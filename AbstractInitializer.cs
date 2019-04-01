using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace QuadTrainTrack
{
    public abstract class AbstractInitializer : MonoBehaviour
    {
        private bool _isInitialized;
        private Dictionary<string, NetInfo> _customPrefabs;
        private static readonly Dictionary<string, NetInfo> OriginalPrefabs = new Dictionary<string, NetInfo>();

        public void Awake()
        {
            DontDestroyOnLoad(this);
            _customPrefabs = new Dictionary<string, NetInfo>();
            OriginalPrefabs.Clear();
        }

        public void OnLevelWasLoaded(int level)
        {
            if (level == 6)
            {
                _customPrefabs.Clear();
                OriginalPrefabs.Clear();
                _isInitialized = false;
            }
        }

        public void Update()
        {
            if (_isInitialized)
            {
                return;
            }
            try
            {
                var parent = GameObject.Find(SimulationManager.instance.m_metaData.m_environment + " Collections");
                foreach (var t in from Transform t in parent.transform where t.name == "Public Transport" select t)
                {
                    t.gameObject.GetComponent<NetCollection>();
                }
            }
            catch (Exception)
            {
                return;
            }
            Loading.QueueLoadingAction(() =>
            {
                try
                {
                InitializeImpl();
                PrefabCollection<NetInfo>.InitializePrefabs("Rail Extensions", _customPrefabs.Values.ToArray(), null);
                }
                catch(Exception ex)
                {
                    Debug.Log(ex.Message);
                    Debug.Log(ex.ToString());
                }
            });
            _isInitialized = true;
        }

        protected abstract void InitializeImpl();
    }
}