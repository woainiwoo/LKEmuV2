﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelotV2.Scripts
{
    public static class Experience
    {
        public static void Load()
        {
            Player.State.ExperienceTable = new Dictionary<int,Dictionary<int,int>>();
            Player.State.ExperienceTable[0] = new Dictionary<int,int>()
            {
                {1, 107},
                {2, 247},
                {3, 428},
                {4, 664},
                {5, 968},
                {6, 1358},
                {7, 1859},
                {8, 2497},
                {9, 3309},
                {10, 4336},
                {11, 5631},
                {12, 7259},
                {13, 9299},
                {14, 11845},
                {15, 15014},
                {16, 18944},
                {17, 23805},
                {18, 29796},
                {19, 37161},
                {20, 46187},
                {21, 57215},
                {22, 70654},
                {23, 86983},
                {24, 106771},
                {25, 130683},
                {26, 159504},
                {27, 194148},
                {28, 235686},
                {29, 285359},
                {30, 344612},
                {31, 415115},
                {32, 498796},
                {33, 597873},
                {34, 714897},
                {35, 852785},
                {36, 1014871},
                {37, 1204953},
                {38, 1427346},
                {39, 1686940},
                {40, 1989262},
                {41, 2340544},
                {42, 2747793},
                {43, 3218867},
                {44, 3762558},
                {45, 4388672},
                {46, 5108122},
                {47, 5933021},
                {48, 6876774},
                {49, 7954182},
                {50, 9181541},
                {51, 10576744},
                {52, 12159386},
                {53, 13950868},
                {54, 15974500},
                {55, 18255595},
                {56, 20821574},
                {57, 23702048},
                {58, 26928907},
                {59, 30536393},
                {60, 34561163},
                {61, 39042345},
                {62, 44021573},
                {63, 49543011},
                {64, 55653353},
                {65, 62401807},
                {66, 69840059},
                {67, 78022199},
                {68, 87004640},
                {69, 96845990},
                {70, 107606903},
                {71, 119349899},
                {72, 132139142},
                {73, 146040195},
                {74, 161119727},
                {75, 177445192},
                {76, 195084469},
                {77, 214105466},
                {78, 234575684},
                {79, 256561752},
                {80, 280128928},
                {81, 305340558},
                {82, 332257524},
                {83, 360937647},
                {84, 391435082},
                {85, 423799685},
                {86, 458076366},
                {87, 494304442},
                {88, 532516975},
                {89, 572740115},
                {90, 614992455},
                {91, 659284397},
                {92, 705617540},
                {93, 753984097},
                {94, 804366346},
                {95, 856736129},
                {96, 911054390},
                {97, 967270783},
                {98, 1025323333},
                {99, 1025323333},
            };

            Player.State.ExperienceTable[1] = new Dictionary<int,int>()
            {
                {1, 235671},
                {2, 487778},
                {3, 756957},
                {4, 1043758},
                {5, 1348733},
                {6, 1673379},
                {7, 2015146},
                {8, 2377426},
                {9, 2759552},
                {10, 3161783},
                {11, 3584307},
                {12, 4027226},
                {13, 4490557},
                {14, 4974223},
                {15, 5478045},
                {16, 6001743},
                {17, 6544926},
                {18, 7107090},
                {19, 7687615},
                {20, 7687615},
            };

            Player.State.ExperienceTable[2] = new Dictionary<int, int>()
            {
                {1, 707013},
                {2, 1463364},
                {3, 2270871},
                {4, 3131274},
                {5, 4046199},
                {6, 5017137},
                {7, 6045438},
                {8, 7132278},
                {9, 8278656},
                {10, 9485349},
                {11, 10752921},
                {12, 12081678},
                {13, 13471671},
                {14, 14922669},
                {15, 16434135},
                {16, 18005229},
                {17, 19634778},
                {18, 21321270},
                {19, 23062845},
                {20, 23062845},
            };

            Player.State.ExperienceTable[3] = new Dictionary<int, int>()
            {
                {1, 1414026},
                {2, 2926728},
                {3, 4543742},
                {4, 6262548},
                {5, 8092398},
                {6, 10034274},
                {7, 12092876},
                {8, 14264556},
                {9, 16557312},
                {10, 18970698},
                {11, 21505842},
                {12, 21463356},
                {13, 26943342},
                {14, 29845338},
                {15, 32868270},
                {16, 36010458},
                {17, 39269556},
                {18, 43642540},
                {19, 46125690},
                {20, 46125690},
            };

            Player.State.ExperienceTable[4] = new Dictionary<int, int>()
            {
                {1, 2828052},
                {2, 5853456},
                {3, 9083484},
                {4, 12525096},
                {5, 16184796},
                {6, 20068548},
                {7, 24181752},
                {8, 28529112},
                {9, 33114824},
                {10, 37941396},
                {11, 43011684},
                {12, 48326712},
                {13, 53886684},
                {14, 59690676},
                {15, 65736540},
                {16, 72020916},
                {17, 78539112},
                {18, 85285080},
                {19, 92251380},
                {20, 92251380},
            };

            Player.State.ExperienceTable[5] = new Dictionary<int, int>()
            {
                {1, 5656104},
                {2, 11706912},
                {3, 18166968},
                {4, 25050192},
                {5, 32369592},
                {6, 40137096},
                {7, 48363504},
                {8, 57058224},
                {9, 66229248},
                {10, 75882792},
                {11, 86023368},
                {12, 96653424},
                {13, 107773368},
                {14, 119381352},
                {15, 131473080},
                {16, 144041832},
                {17, 157078224},
                {18, 170570161},
                {19, 184502760},
                {20, 184502760},
            };

            Player.State.ExperienceTable[6] = new Dictionary<int, int>()
            {
                {1, 11312208},
                {2, 23413824},
                {3, 36339364},
                {4, 50100384},
                {5, 64739184},
                {6, 80274192},
                {7, 96727008},
                {8, 114116448},
                {9, 132458496},
                {10, 151765584},
                {11, 172046736},
                {12, 193306848},
                {13, 215546736},
                {14, 238762704},
                {15, 262946160},
                {16, 288083664},
                {17, 314156448},
                {18, 341140320},
                {19, 369005520},
                {20, 369005520},
            };

            Player.State.ExperienceTable[7] = new Dictionary<int, int>()
            {
                {1, 3393663},
                {2, 7024004},
                {3, 10900182},
                {4, 15030117},
                {5, 19425108},
                {6, 24100818},
                {7, 29023112},
                {8, 33688025},
                {9, 38598376},
                {10, 43756459},
                {11, 49163521},
                {12, 55238742},
                {13, 61593940},
                {14, 68228061},
                {15, 75138647},
                {16, 81939011},
                {17, 89354836},
                {18, 97029801},
                {19, 104955439},
                {20, 113222343},
            };

            Player.State.ExperienceTable[8] = new Dictionary<int, int>()
            {
                {1, 6787326},
                {2, 14048008},
                {3, 21800365},
                {4, 30060235},
                {5, 38850217},
                {6, 48201636},
                {7, 58046226},
                {8, 67376052},
                {9, 77196754},
                {10, 87512921},
                {11, 98327043},
                {12, 109639537},
                {13, 121448521},
                {14, 133749625},
                {15, 146536014},
                {16, 159798140},
                {17, 173523698},
                {18, 187697551},
                {19, 202481707},
                {20, 202481707},
            };

            Player.State.ExperienceTable[9] = new Dictionary<int, int>()
            {
                {1, 13574652},
                {2, 28096017},
                {3, 43600730},
                {4, 60120471},
                {5, 77700434},
                {6, 96403272},
                {7, 116092450},
                {8, 134752103},
                {9, 154393506},
                {10, 175025840},
                {11, 196654085},
                {12, 219279072},
                {13, 242897040},
                {14, 267499248},
                {15, 293072025},
                {16, 319596277},
                {17, 347047393},
                {18, 375395097},
                {19, 404963410},
                {20, 404963410},
            };

            Player.State.ExperienceTable[10] = new Dictionary<int, int>()
            {
                {1, 27149304},
                {2, 56192035},
                {3, 87201461},
                {4, 120240942},
                {5, 155400868},
                {6, 192806545},
                {7, 232184901},
                {8, 269504207},
                {9, 308787013},
                {10, 350051680},
                {11, 393308170},
                {12, 438558144},
                {13, 485794080},
                {14, 534998497},
                {15, 586144051},
                {16, 639192554},
                {17, 697042170},
                {18, 753978329},
                {19, 813366070},
                {20, 813366070},
            };

            Player.State.ExperienceTable[11] = new Dictionary<int, int>()
            {
                {1, 54298608},
                {2, 112384071},
                {3, 174402923},
                {4, 240481885},
                {5, 310801737},
                {6, 385613090},
                {7, 464369802},
                {8, 539008414},
                {9, 617574026},
                {10, 700103361},
                {11, 786616341},
                {12, 877116288},
                {13, 971588160},
                {14, 1069996995},
                {15, 1172288102},
                {16, 1278385108},
                {17, 1388189572},
                {18, 1501580390},
                {19, 1619853640},
                {20, 1619853640},
            };

            Player.State.ExperienceTable[12] = new Dictionary<int, int>()
            {
                {1, 16289582},
                {2, 33715220},
                {3, 52320875},
                {4, 72144563},
                {5, 93240518},
                {6, 115683924},
                {7, 139310937},
                {8, 161702520},
                {9, 185272203},
                {10, 210031003},
                {11, 235984896},
                {12, 263134879},
                {13, 291476440},
                {14, 320999090},
                {15, 351686421},
                {16, 383515523},
                {17, 416456861},
                {18, 450474106},
                {19, 485956080},
                {20, 485956080},
            };
        }
    }
}
