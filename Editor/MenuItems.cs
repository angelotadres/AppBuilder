using UnityEditor;

namespace AppBuilder {
    public class MenuItems {
        
        [MenuItem ("Tools/AppBuilder/Show Settings")]
        private static void ShowSettings () {
            SettingsWindow.ShowSettings ();
        }
    }        
}