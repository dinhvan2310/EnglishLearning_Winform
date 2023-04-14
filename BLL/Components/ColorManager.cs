using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Components
{
    public class ColorManager
    {
        public Theme CurrentTheme { get; private set; }

        public enum Theme
        {
            DarkPurple,
        }
        public void ChangeTheme(Theme theme)
        {
            CurrentTheme = theme;
        }

        public Color BaseColor { get; private set; } = Color.FromArgb(62, 60, 102);
        public Color FrameColor { get; private set; } = Color.FromArgb(48, 48, 87);
        public Color DarkFrameColor { get; private set; } = Color.FromArgb(44, 41, 74);
        public Color LightFrameColor { get; private set; } = Color.FromArgb(60, 50, 99);
        public Color TextFrameColor { get; private set; } = Color.FromArgb(75, 65, 114);
        public Color TextColor { get; private set; } = Color.FromArgb(240, 237, 254);
        public Color LightTextColor { get; private set; } = Color.FromArgb(119, 112, 156);
        public Color DarkTextColor { get; private set; } = Color.FromArgb(44, 41, 74);

    }
}
