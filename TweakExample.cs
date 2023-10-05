using ImGuiNET;
using SimpleTweaksPlugin.TweakSystem;

namespace TweakProviderExample; 

[TweakName("Tweak Example")]
[TweakDescription("An example tweak")]
[TweakAuthor("Caraxi")]
public class TweakExample : TweakManagerExample.SubTweak {
    private void DrawConfig() {
        ImGui.Text("Hello World");
    }
}
