﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// a scriptable object can be changed from within the editor
// and is useful for holding data that won't be changed in-game
// mostly used for level design, I think
// like to switch between difficulty presets for example
// or graphical themes
namespace Nolanfa.BackgroundElementsRandomizer
{
    [CreateAssetMenu(fileName = "BackgroundType", menuName = "ScriptableObjects/Background Type", order = 1)]
    public class BackgroundType : ScriptableObject
    {
        public BackgroundTypes Type;

        [Header("Object")]

        public bool IsLocked;
        public RotationalAbility RotationalAbility;
        [Tooltip("Scalability in % either way; with a scalability of 20, an object can be from 80% to 120% big")]
        public int Scalability;

        [Header("Meshes")]

        public Mesh geometricMesh;
        public string MeshesFolder;
        public bool FindMeshesByName;
        [HideInInspector]
        public List<Mesh> Meshes;

        [Header("Materials")]

        public List<Material> Materials;
        [HideInInspector]
        public List<Material> NewMaterials;

        [Header("Textures")]

        public bool ShouldOffsetTexture;
        public Vector2 TextureTiling;

        [Header("Colliders")]

        public bool CanCollide;
        public bool ShouldBlockUpwards;
    }

    public enum BackgroundTypes
    {
        House,
        Tree
    };

    public enum RotationalAbility
    {
        None,
        By180Degrees,
        By90Degrees,
        By30Degrees,
        Anything
    }
}