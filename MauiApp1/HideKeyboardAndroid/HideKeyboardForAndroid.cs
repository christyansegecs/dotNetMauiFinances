using Microsoft.Maui.Platform;

namespace AppMauiFinances.HideKeyboardAndroid
{
    public class HideKeyboardForAndroid
    {
        public static void HideKeyboard()
        {
#if ANDROID
            if (Platform.CurrentActivity.CurrentFocus != null)
            {
                Platform.CurrentActivity.HideKeyboard(Platform.CurrentActivity.CurrentFocus);
            }
#endif
        }
    }
}
