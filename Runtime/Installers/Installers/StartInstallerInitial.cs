using UnityEngine;

namespace Toranzo.Installer
{
    public class StartInstallerInitial : MonoBehaviour
    {
        [SerializeField] private MonoInstaller _monoInstaller;

        private void Start()
        {
            _monoInstaller.Install();
        }
    }
}
