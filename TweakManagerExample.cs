using SimpleTweaksPlugin.TweakSystem;

namespace TweakProviderExample; 

[TweakName("Tweak Manager Example")]
public class TweakManagerExample : SubTweakManager<TweakManagerExample.SubTweak> {
    public abstract class SubTweak : BaseTweak {
        public override string Key => $"{nameof(TweakManagerExample)}@{base.Key}";
    }
}
