/*------------------------------------------------------------*/
// <summary>GameCanvas for Unity</summary>
// <author>Seibe TAKAHASHI</author>
// <remarks>
// (c) 2015-2020 Smart Device Programming.
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
// </remarks>
/*------------------------------------------------------------*/
namespace GameCanvas
{
    public readonly partial struct GcImage : System.IEquatable<GcImage>
    {
        internal const int __Length__ = 54;
        public static readonly GcImage BallBlue = new GcImage("BallBlue", 24, 24);
        public static readonly GcImage BallRed = new GcImage("BallRed", 24, 24);
        public static readonly GcImage BallYellow = new GcImage("BallYellow", 24, 24);
        public static readonly GcImage Block = new GcImage("Block", 32, 32);
        public static readonly GcImage BlueSky = new GcImage("BlueSky", 640, 480);
        public static readonly GcImage Bullet0 = new GcImage("Bullet0", 31, 90);
        public static readonly GcImage Bullet1 = new GcImage("Bullet1", 89, 139);
        public static readonly GcImage Bullet2 = new GcImage("Bullet2", 93, 153);
        public static readonly GcImage Bullet3 = new GcImage("Bullet3", 91, 204);
        public static readonly GcImage Bullet4 = new GcImage("Bullet4", 90, 229);
        public static readonly GcImage Bullet5 = new GcImage("Bullet5", 106, 232);
        public static readonly GcImage GL0 = new GcImage("GL0", 32, 32);
        public static readonly GcImage GR0 = new GcImage("GR0", 32, 32);
        public static readonly GcImage Life = new GcImage("Life", 224, 223);
        public static readonly GcImage Orangethemespritesheet1_0 = new GcImage("Orange theme spritesheet 1_0", 80, 51);
        public static readonly GcImage Orangethemespritesheet1_1 = new GcImage("Orange theme spritesheet 1_1", 80, 51);
        public static readonly GcImage Orangethemespritesheet1_11 = new GcImage("Orange theme spritesheet 1_11", 198, 210);
        public static readonly GcImage Orangethemespritesheet1_12 = new GcImage("Orange theme spritesheet 1_12", 196, 102);
        public static readonly GcImage Orangethemespritesheet1_13 = new GcImage("Orange theme spritesheet 1_13", 43, 41);
        public static readonly GcImage Orangethemespritesheet1_16 = new GcImage("Orange theme spritesheet 1_16", 44, 48);
        public static readonly GcImage Orangethemespritesheet1_17 = new GcImage("Orange theme spritesheet 1_17", 196, 100);
        public static readonly GcImage Orangethemespritesheet1_18 = new GcImage("Orange theme spritesheet 1_18", 42, 48);
        public static readonly GcImage Orangethemespritesheet1_19 = new GcImage("Orange theme spritesheet 1_19", 47, 162);
        public static readonly GcImage Orangethemespritesheet1_2 = new GcImage("Orange theme spritesheet 1_2", 99, 54);
        public static readonly GcImage Orangethemespritesheet1_20 = new GcImage("Orange theme spritesheet 1_20", 132, 41);
        public static readonly GcImage Orangethemespritesheet1_21 = new GcImage("Orange theme spritesheet 1_21", 81, 327);
        public static readonly GcImage Orangethemespritesheet1_23 = new GcImage("Orange theme spritesheet 1_23", 106, 184);
        public static readonly GcImage Orangethemespritesheet1_24 = new GcImage("Orange theme spritesheet 1_24", 103, 197);
        public static readonly GcImage Orangethemespritesheet1_25 = new GcImage("Orange theme spritesheet 1_25", 86, 214);
        public static readonly GcImage Orangethemespritesheet1_26 = new GcImage("Orange theme spritesheet 1_26", 206, 374);
        public static readonly GcImage Orangethemespritesheet1_27 = new GcImage("Orange theme spritesheet 1_27", 207, 270);
        public static readonly GcImage Orangethemespritesheet1_28 = new GcImage("Orange theme spritesheet 1_28", 211, 384);
        public static readonly GcImage Orangethemespritesheet1_29 = new GcImage("Orange theme spritesheet 1_29", 209, 298);
        public static readonly GcImage Orangethemespritesheet1_3 = new GcImage("Orange theme spritesheet 1_3", 165, 235);
        public static readonly GcImage Orangethemespritesheet1_30 = new GcImage("Orange theme spritesheet 1_30", 54, 223);
        public static readonly GcImage Orangethemespritesheet1_31 = new GcImage("Orange theme spritesheet 1_31", 118, 56);
        public static readonly GcImage Orangethemespritesheet1_32 = new GcImage("Orange theme spritesheet 1_32", 117, 59);
        public static readonly GcImage Orangethemespritesheet1_33 = new GcImage("Orange theme spritesheet 1_33", 98, 90);
        public static readonly GcImage Orangethemespritesheet1_34 = new GcImage("Orange theme spritesheet 1_34", 138, 147);
        public static readonly GcImage Orangethemespritesheet1_35 = new GcImage("Orange theme spritesheet 1_35", 126, 151);
        public static readonly GcImage Orangethemespritesheet1_36 = new GcImage("Orange theme spritesheet 1_36", 527, 245);
        public static readonly GcImage Orangethemespritesheet1_37 = new GcImage("Orange theme spritesheet 1_37", 221, 149);
        public static readonly GcImage Orangethemespritesheet1_38 = new GcImage("Orange theme spritesheet 1_38", 300, 363);
        public static readonly GcImage Orangethemespritesheet1_39 = new GcImage("Orange theme spritesheet 1_39", 306, 375);
        public static readonly GcImage Orangethemespritesheet1_4 = new GcImage("Orange theme spritesheet 1_4", 165, 233);
        public static readonly GcImage Orangethemespritesheet1_40 = new GcImage("Orange theme spritesheet 1_40", 527, 245);
        public static readonly GcImage Orangethemespritesheet1_41 = new GcImage("Orange theme spritesheet 1_41", 166, 349);
        public static readonly GcImage Orangethemespritesheet1_42 = new GcImage("Orange theme spritesheet 1_42", 411, 309);
        public static readonly GcImage Orangethemespritesheet1_43 = new GcImage("Orange theme spritesheet 1_43", 433, 325);
        public static readonly GcImage Orangethemespritesheet1_45 = new GcImage("Orange theme spritesheet 1_45", 308, 308);
        public static readonly GcImage Orangethemespritesheet1_46 = new GcImage("Orange theme spritesheet 1_46", 667, 160);
        public static readonly GcImage Orangethemespritesheet1_5 = new GcImage("Orange theme spritesheet 1_5", 185, 306);
        public static readonly GcImage Orangethemespritesheet1_6 = new GcImage("Orange theme spritesheet 1_6", 82, 61);
        public static readonly GcImage Orangethemespritesheet1_7 = new GcImage("Orange theme spritesheet 1_7", 86, 52);
    }
}
