using ImGuiNET;
using SimpleTweaksPlugin.Debugging;

namespace TweakProviderExample;

public class DebugPageExample : DebugHelper {
    public override void Draw() {
        ImGui.Text("Hello World");
    }

    public override string Name => "Debug Page Example";
}
