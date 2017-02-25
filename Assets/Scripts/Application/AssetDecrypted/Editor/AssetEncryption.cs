﻿
using CatLib.API.ResourcesSystem;
using UnityEditor;

namespace CatLib.ResourcesSystem
{

    /// <summary>
    /// 对打包的资源加入加密策略
    /// </summary>
    public class AssetEncryption : IBuildStrategy
    {

        public BuildProcess Process { get { return BuildProcess.Encryption; } }

        public void Build(IBuildContext context)
        {


            foreach (string releaseFile in context.ReleaseFiles)
            {
                //todo: 进行加密
                UnityEngine.Debug.Log(releaseFile);
            }

            context.EncryptionFiles = context.ReleaseFiles;
        }



    }

}