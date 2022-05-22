﻿using EditorEX.Managers;
using EditorEX.Views;
using Zenject;

namespace EditorEX.Installers
{
    internal class EXGameCoreInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ColorManagerInstanceManager>().AsSingle().NonLazy();
        }
    }
}
