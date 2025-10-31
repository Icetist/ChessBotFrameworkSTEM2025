using Raylib_cs;

namespace ChessChallenge.Application
{
    public class BoardTheme
    {
        public Color LightCol = new Color(232, 237, 249, 255);
        public Color DarkCol = new Color(183, 192, 216, 255);

        public Color selectedLight = new Color(236, 197, 123, 255);
        public Color selectedDark = new Color(200, 158, 80, 255);

        public Color MoveFromLight = new Color(152, 105, 207, 255);
        public Color MoveFromDark = new Color(147, 53, 196, 255);

        public Color MoveToLight = new Color(171, 124, 222, 255);
        public Color MoveToDark = new Color(156, 96, 196, 255);

        public Color LegalLight = new Color(89, 171, 221, 255);
        public Color LegalDark = new Color(62, 144, 195, 255);

        public Color CheckLight = new Color(234, 74, 74, 255);
        public Color CheckDark = new Color(207, 39, 39, 255);

        public Color BorderCol = new Color(44, 44, 44, 255);

        public Color LightCoordCol = new Color(243, 219, 255, 255);
        public Color DarkCoordCol = new Color(97, 80, 140, 255);
    }
}

