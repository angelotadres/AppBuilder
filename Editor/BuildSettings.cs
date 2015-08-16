using UnityEditor;

namespace AppBuilder {
    public class BuildSettings {
        
        public static void UpdateSettings () {
            // General
            PlayerSettings.companyName = "Packtpub";
            PlayerSettings.productName = "Run And Jump";
            PlayerSettings.bundleVersion = "1.0";
            
            // Android
            PlayerSettings.bundleIdentifier = "com.packtpub.runandjump";
        }
    }
}