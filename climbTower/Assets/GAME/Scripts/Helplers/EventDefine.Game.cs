using UnityEngine;

public partial class EventDefine {
    // ─────────────────────────────────────────
    //  GAME EVENTS
    // ─────────────────────────────────────────

    public struct OnChangeStateJoyStick : IEventParam { public bool IsChange; }
    public struct OnTimeEnd : IEventParam { }
    public struct OnUpdateProgress : IEventParam { }
    public struct OnKilled : IEventParam { public GameObject KilledCharacter; }
    public struct OnChangeSkin : IEventParam { public int skinID; }
    public struct OnFinishGameSession : IEventParam { }
    public struct OnFinishBoosterGift : IEventParam { }
    public struct OnFinishPopup : IEventParam { public string PopupName; public bool IsRewardFinsh; };
    public struct OnUpdateBoosterDisplay : IEventParam { }

}
