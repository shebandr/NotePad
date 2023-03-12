using System.Collections.Generic;

namespace NotePad.Models {
    public class Sravn: IComparer<string> {
        public int Compare(string? XCoord, string? YCord) {
            if (XCoord == null && YCord == null) return 0;
            if (XCoord == null) return -1;
            if (YCord == null) return 1;

            int lx = XCoord.Length, ly = YCord.Length;

            for (int mx = 0, my = 0; mx < lx && my < ly; mx++, my++) {
                if (char.IsDigit(XCoord[mx]) && char.IsDigit(YCord[my])) {
                    long vx = 0, vy = 0;

                    for (; mx < lx && char.IsDigit(XCoord[mx]); mx++)
                        vx = vx * 10 + XCoord[mx] - '0';

                    for (; my < ly && char.IsDigit(YCord[my]); my++)
                        vy = vy * 10 + YCord[my] - '0';

                    if (vx != vy)
                        return vx > vy ? 1 : -1;
                }

                if (mx < lx && my < ly && XCoord[mx] != YCord[my])
                    return XCoord[mx] > YCord[my] ? 1 : -1;
            }

            return lx - ly;
        }
    }
}