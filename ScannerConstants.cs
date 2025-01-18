﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCompilador
{
    public class ScannerConstants
    {
        public readonly int[] SCANNER_TABLE_INDEXES =
    {
        0,
        54,
        54,
        55,
        247,
        248,
        248,
        248,
        248,
        248,
        248,
        248,
        248,
        249,
        260,
        260,
        260,
        261,
        262,
        314,
        367,
        368,
        368,
        368,
        369,
        369,
        379,
        379,
        380,
        432,
        432,
        442,
        634,
        670,
        732,
        742,
        935,
        997,
        1059,
        1095,
        1096,
        1096
    };

        public readonly int[,] SCANNER_TABLE =
        {
        {9, 1},
        {10, 1},
        {32, 1},
        {33, 2},
        {34, 3},
        {38, 4},
        {40, 5},
        {41, 6},
        {42, 7},
        {43, 8},
        {44, 9},
        {45, 10},
        {47, 11},
        {48, 12},
        {49, 13},
        {50, 13},
        {51, 13},
        {52, 13},
        {53, 13},
        {54, 13},
        {55, 13},
        {56, 13},
        {57, 13},
        {59, 14},
        {60, 15},
        {61, 16},
        {62, 17},
        {97, 18},
        {98, 19},
        {99, 18},
        {100, 18},
        {101, 18},
        {102, 19},
        {103, 18},
        {104, 18},
        {105, 19},
        {106, 18},
        {107, 18},
        {108, 18},
        {109, 18},
        {110, 18},
        {111, 18},
        {112, 18},
        {113, 18},
        {114, 18},
        {115, 19},
        {116, 18},
        {117, 18},
        {118, 18},
        {119, 18},
        {120, 18},
        {121, 18},
        {122, 18},
        {124, 20},
        {61, 21},
        {9, 3},
        {13, 3},
        {32, 3},
        {33, 3},
        {34, 22},
        {35, 3},
        {36, 3},
        {37, 23},
        {38, 3},
        {39, 3},
        {40, 3},
        {41, 3},
        {42, 3},
        {43, 3},
        {44, 3},
        {45, 3},
        {46, 3},
        {47, 3},
        {48, 3},
        {49, 3},
        {50, 3},
        {51, 3},
        {52, 3},
        {53, 3},
        {54, 3},
        {55, 3},
        {56, 3},
        {57, 3},
        {58, 3},
        {59, 3},
        {60, 3},
        {61, 3},
        {62, 3},
        {63, 3},
        {64, 3},
        {65, 3},
        {66, 3},
        {67, 3},
        {68, 3},
        {69, 3},
        {70, 3},
        {71, 3},
        {72, 3},
        {73, 3},
        {74, 3},
        {75, 3},
        {76, 3},
        {77, 3},
        {78, 3},
        {79, 3},
        {80, 3},
        {81, 3},
        {82, 3},
        {83, 3},
        {84, 3},
        {85, 3},
        {86, 3},
        {87, 3},
        {88, 3},
        {89, 3},
        {90, 3},
        {91, 3},
        {92, 3},
        {93, 3},
        {94, 3},
        {95, 3},
        {96, 3},
        {97, 3},
        {98, 3},
        {99, 3},
        {100, 3},
        {101, 3},
        {102, 3},
        {103, 3},
        {104, 3},
        {105, 3},
        {106, 3},
        {107, 3},
        {108, 3},
        {109, 3},
        {110, 3},
        {111, 3},
        {112, 3},
        {113, 3},
        {114, 3},
        {115, 3},
        {116, 3},
        {117, 3},
        {118, 3},
        {119, 3},
        {120, 3},
        {121, 3},
        {122, 3},
        {123, 3},
        {124, 3},
        {125, 3},
        {126, 3},
        {161, 3},
        {162, 3},
        {163, 3},
        {164, 3},
        {165, 3},
        {166, 3},
        {167, 3},
        {168, 3},
        {169, 3},
        {170, 3},
        {171, 3},
        {172, 3},
        {173, 3},
        {174, 3},
        {175, 3},
        {176, 3},
        {177, 3},
        {178, 3},
        {179, 3},
        {180, 3},
        {181, 3},
        {182, 3},
        {183, 3},
        {184, 3},
        {185, 3},
        {186, 3},
        {187, 3},
        {188, 3},
        {189, 3},
        {190, 3},
        {191, 3},
        {192, 3},
        {193, 3},
        {194, 3},
        {195, 3},
        {196, 3},
        {197, 3},
        {198, 3},
        {199, 3},
        {200, 3},
        {201, 3},
        {202, 3},
        {203, 3},
        {204, 3},
        {205, 3},
        {206, 3},
        {207, 3},
        {208, 3},
        {209, 3},
        {210, 3},
        {211, 3},
        {212, 3},
        {213, 3},
        {214, 3},
        {215, 3},
        {216, 3},
        {217, 3},
        {218, 3},
        {219, 3},
        {220, 3},
        {221, 3},
        {222, 3},
        {223, 3},
        {224, 3},
        {225, 3},
        {226, 3},
        {227, 3},
        {228, 3},
        {229, 3},
        {230, 3},
        {231, 3},
        {232, 3},
        {233, 3},
        {234, 3},
        {235, 3},
        {236, 3},
        {237, 3},
        {238, 3},
        {239, 3},
        {240, 3},
        {241, 3},
        {242, 3},
        {243, 3},
        {244, 3},
        {245, 3},
        {246, 3},
        {247, 3},
        {248, 3},
        {249, 3},
        {250, 3},
        {251, 3},
        {252, 3},
        {253, 3},
        {254, 3},
        {255, 3},
        {38, 24},
        {44, 25},
        {44, 25},
        {48, 13},
        {49, 13},
        {50, 13},
        {51, 13},
        {52, 13},
        {53, 13},
        {54, 13},
        {55, 13},
        {56, 13},
        {57, 13},
        {61, 26},
        {64, 27},
        {65, 18},
        {66, 18},
        {67, 18},
        {68, 18},
        {69, 18},
        {70, 18},
        {71, 18},
        {72, 18},
        {73, 18},
        {74, 18},
        {75, 18},
        {76, 18},
        {77, 18},
        {78, 18},
        {79, 18},
        {80, 18},
        {81, 18},
        {82, 18},
        {83, 18},
        {84, 18},
        {85, 18},
        {86, 18},
        {87, 18},
        {88, 18},
        {89, 18},
        {90, 18},
        {97, 18},
        {98, 18},
        {99, 18},
        {100, 18},
        {101, 18},
        {102, 18},
        {103, 18},
        {104, 18},
        {105, 18},
        {106, 18},
        {107, 18},
        {108, 18},
        {109, 18},
        {110, 18},
        {111, 18},
        {112, 18},
        {113, 18},
        {114, 18},
        {115, 18},
        {116, 18},
        {117, 18},
        {118, 18},
        {119, 18},
        {120, 18},
        {121, 18},
        {122, 18},
        {65, 18},
        {66, 18},
        {67, 18},
        {68, 18},
        {69, 18},
        {70, 18},
        {71, 18},
        {72, 18},
        {73, 18},
        {74, 18},
        {75, 18},
        {76, 18},
        {77, 18},
        {78, 18},
        {79, 18},
        {80, 18},
        {81, 18},
        {82, 18},
        {83, 18},
        {84, 18},
        {85, 18},
        {86, 18},
        {87, 18},
        {88, 18},
        {89, 18},
        {90, 18},
        {95, 28},
        {97, 18},
        {98, 18},
        {99, 18},
        {100, 18},
        {101, 18},
        {102, 18},
        {103, 18},
        {104, 18},
        {105, 18},
        {106, 18},
        {107, 18},
        {108, 18},
        {109, 18},
        {110, 18},
        {111, 18},
        {112, 18},
        {113, 18},
        {114, 18},
        {115, 18},
        {116, 18},
        {117, 18},
        {118, 18},
        {119, 18},
        {120, 18},
        {121, 18},
        {122, 18},
        {124, 29},
        {120, 3},
        {48, 30},
        {49, 30},
        {50, 30},
        {51, 30},
        {52, 30},
        {53, 30},
        {54, 30},
        {55, 30},
        {56, 30},
        {57, 30},
        {10, 31},
        {65, 32},
        {66, 32},
        {67, 32},
        {68, 32},
        {69, 32},
        {70, 32},
        {71, 32},
        {72, 32},
        {73, 32},
        {74, 32},
        {75, 32},
        {76, 32},
        {77, 32},
        {78, 32},
        {79, 32},
        {80, 32},
        {81, 32},
        {82, 32},
        {83, 32},
        {84, 32},
        {85, 32},
        {86, 32},
        {87, 32},
        {88, 32},
        {89, 32},
        {90, 32},
        {97, 33},
        {98, 33},
        {99, 33},
        {100, 33},
        {101, 33},
        {102, 33},
        {103, 33},
        {104, 33},
        {105, 33},
        {106, 33},
        {107, 33},
        {108, 33},
        {109, 33},
        {110, 33},
        {111, 33},
        {112, 33},
        {113, 33},
        {114, 33},
        {115, 33},
        {116, 33},
        {117, 33},
        {118, 33},
        {119, 33},
        {120, 33},
        {121, 33},
        {122, 33},
        {48, 34},
        {49, 30},
        {50, 30},
        {51, 30},
        {52, 30},
        {53, 30},
        {54, 30},
        {55, 30},
        {56, 30},
        {57, 30},
        {9, 31},
        {10, 35},
        {13, 31},
        {32, 31},
        {33, 31},
        {34, 31},
        {35, 31},
        {36, 31},
        {37, 31},
        {38, 31},
        {39, 31},
        {40, 31},
        {41, 31},
        {42, 31},
        {43, 31},
        {44, 31},
        {45, 31},
        {46, 31},
        {47, 31},
        {48, 31},
        {49, 31},
        {50, 31},
        {51, 31},
        {52, 31},
        {53, 31},
        {54, 31},
        {55, 31},
        {56, 31},
        {57, 31},
        {58, 31},
        {59, 31},
        {60, 31},
        {61, 31},
        {62, 31},
        {63, 31},
        {65, 31},
        {66, 31},
        {67, 31},
        {68, 31},
        {69, 31},
        {70, 31},
        {71, 31},
        {72, 31},
        {73, 31},
        {74, 31},
        {75, 31},
        {76, 31},
        {77, 31},
        {78, 31},
        {79, 31},
        {80, 31},
        {81, 31},
        {82, 31},
        {83, 31},
        {84, 31},
        {85, 31},
        {86, 31},
        {87, 31},
        {88, 31},
        {89, 31},
        {90, 31},
        {91, 31},
        {92, 31},
        {93, 31},
        {94, 31},
        {95, 31},
        {96, 31},
        {97, 31},
        {98, 31},
        {99, 31},
        {100, 31},
        {101, 31},
        {102, 31},
        {103, 31},
        {104, 31},
        {105, 31},
        {106, 31},
        {107, 31},
        {108, 31},
        {109, 31},
        {110, 31},
        {111, 31},
        {112, 31},
        {113, 31},
        {114, 31},
        {115, 31},
        {116, 31},
        {117, 31},
        {118, 31},
        {119, 31},
        {120, 31},
        {121, 31},
        {122, 31},
        {123, 31},
        {124, 31},
        {125, 31},
        {126, 31},
        {161, 31},
        {162, 31},
        {163, 31},
        {164, 31},
        {165, 31},
        {166, 31},
        {167, 31},
        {168, 31},
        {169, 31},
        {170, 31},
        {171, 31},
        {172, 31},
        {173, 31},
        {174, 31},
        {175, 31},
        {176, 31},
        {177, 31},
        {178, 31},
        {179, 31},
        {180, 31},
        {181, 31},
        {182, 31},
        {183, 31},
        {184, 31},
        {185, 31},
        {186, 31},
        {187, 31},
        {188, 31},
        {189, 31},
        {190, 31},
        {191, 31},
        {192, 31},
        {193, 31},
        {194, 31},
        {195, 31},
        {196, 31},
        {197, 31},
        {198, 31},
        {199, 31},
        {200, 31},
        {201, 31},
        {202, 31},
        {203, 31},
        {204, 31},
        {205, 31},
        {206, 31},
        {207, 31},
        {208, 31},
        {209, 31},
        {210, 31},
        {211, 31},
        {212, 31},
        {213, 31},
        {214, 31},
        {215, 31},
        {216, 31},
        {217, 31},
        {218, 31},
        {219, 31},
        {220, 31},
        {221, 31},
        {222, 31},
        {223, 31},
        {224, 31},
        {225, 31},
        {226, 31},
        {227, 31},
        {228, 31},
        {229, 31},
        {230, 31},
        {231, 31},
        {232, 31},
        {233, 31},
        {234, 31},
        {235, 31},
        {236, 31},
        {237, 31},
        {238, 31},
        {239, 31},
        {240, 31},
        {241, 31},
        {242, 31},
        {243, 31},
        {244, 31},
        {245, 31},
        {246, 31},
        {247, 31},
        {248, 31},
        {249, 31},
        {250, 31},
        {251, 31},
        {252, 31},
        {253, 31},
        {254, 31},
        {255, 31},
        {48, 36},
        {49, 36},
        {50, 36},
        {51, 36},
        {52, 36},
        {53, 36},
        {54, 36},
        {55, 36},
        {56, 36},
        {57, 36},
        {97, 36},
        {98, 36},
        {99, 36},
        {100, 36},
        {101, 36},
        {102, 36},
        {103, 36},
        {104, 36},
        {105, 36},
        {106, 36},
        {107, 36},
        {108, 36},
        {109, 36},
        {110, 36},
        {111, 36},
        {112, 36},
        {113, 36},
        {114, 36},
        {115, 36},
        {116, 36},
        {117, 36},
        {118, 36},
        {119, 36},
        {120, 36},
        {121, 36},
        {122, 36},
        {48, 37},
        {49, 37},
        {50, 37},
        {51, 37},
        {52, 37},
        {53, 37},
        {54, 37},
        {55, 37},
        {56, 37},
        {57, 37},
        {65, 38},
        {66, 38},
        {67, 38},
        {68, 38},
        {69, 38},
        {70, 38},
        {71, 38},
        {72, 38},
        {73, 38},
        {74, 38},
        {75, 38},
        {76, 38},
        {77, 38},
        {78, 38},
        {79, 38},
        {80, 38},
        {81, 38},
        {82, 38},
        {83, 38},
        {84, 38},
        {85, 38},
        {86, 38},
        {87, 38},
        {88, 38},
        {89, 38},
        {90, 38},
        {97, 37},
        {98, 37},
        {99, 37},
        {100, 37},
        {101, 37},
        {102, 37},
        {103, 37},
        {104, 37},
        {105, 37},
        {106, 37},
        {107, 37},
        {108, 37},
        {109, 37},
        {110, 37},
        {111, 37},
        {112, 37},
        {113, 37},
        {114, 37},
        {115, 37},
        {116, 37},
        {117, 37},
        {118, 37},
        {119, 37},
        {120, 37},
        {121, 37},
        {122, 37},
        {48, 34},
        {49, 30},
        {50, 30},
        {51, 30},
        {52, 30},
        {53, 30},
        {54, 30},
        {55, 30},
        {56, 30},
        {57, 30},
        {9, 31},
        {10, 35},
        {13, 31},
        {32, 31},
        {33, 31},
        {34, 31},
        {35, 31},
        {36, 31},
        {37, 31},
        {38, 31},
        {39, 31},
        {40, 31},
        {41, 31},
        {42, 31},
        {43, 31},
        {44, 31},
        {45, 31},
        {46, 31},
        {47, 31},
        {48, 31},
        {49, 31},
        {50, 31},
        {51, 31},
        {52, 31},
        {53, 31},
        {54, 31},
        {55, 31},
        {56, 31},
        {57, 31},
        {58, 31},
        {59, 31},
        {60, 31},
        {61, 31},
        {62, 31},
        {63, 31},
        {64, 39},
        {65, 31},
        {66, 31},
        {67, 31},
        {68, 31},
        {69, 31},
        {70, 31},
        {71, 31},
        {72, 31},
        {73, 31},
        {74, 31},
        {75, 31},
        {76, 31},
        {77, 31},
        {78, 31},
        {79, 31},
        {80, 31},
        {81, 31},
        {82, 31},
        {83, 31},
        {84, 31},
        {85, 31},
        {86, 31},
        {87, 31},
        {88, 31},
        {89, 31},
        {90, 31},
        {91, 31},
        {92, 31},
        {93, 31},
        {94, 31},
        {95, 31},
        {96, 31},
        {97, 31},
        {98, 31},
        {99, 31},
        {100, 31},
        {101, 31},
        {102, 31},
        {103, 31},
        {104, 31},
        {105, 31},
        {106, 31},
        {107, 31},
        {108, 31},
        {109, 31},
        {110, 31},
        {111, 31},
        {112, 31},
        {113, 31},
        {114, 31},
        {115, 31},
        {116, 31},
        {117, 31},
        {118, 31},
        {119, 31},
        {120, 31},
        {121, 31},
        {122, 31},
        {123, 31},
        {124, 31},
        {125, 31},
        {126, 31},
        {161, 31},
        {162, 31},
        {163, 31},
        {164, 31},
        {165, 31},
        {166, 31},
        {167, 31},
        {168, 31},
        {169, 31},
        {170, 31},
        {171, 31},
        {172, 31},
        {173, 31},
        {174, 31},
        {175, 31},
        {176, 31},
        {177, 31},
        {178, 31},
        {179, 31},
        {180, 31},
        {181, 31},
        {182, 31},
        {183, 31},
        {184, 31},
        {185, 31},
        {186, 31},
        {187, 31},
        {188, 31},
        {189, 31},
        {190, 31},
        {191, 31},
        {192, 31},
        {193, 31},
        {194, 31},
        {195, 31},
        {196, 31},
        {197, 31},
        {198, 31},
        {199, 31},
        {200, 31},
        {201, 31},
        {202, 31},
        {203, 31},
        {204, 31},
        {205, 31},
        {206, 31},
        {207, 31},
        {208, 31},
        {209, 31},
        {210, 31},
        {211, 31},
        {212, 31},
        {213, 31},
        {214, 31},
        {215, 31},
        {216, 31},
        {217, 31},
        {218, 31},
        {219, 31},
        {220, 31},
        {221, 31},
        {222, 31},
        {223, 31},
        {224, 31},
        {225, 31},
        {226, 31},
        {227, 31},
        {228, 31},
        {229, 31},
        {230, 31},
        {231, 31},
        {232, 31},
        {233, 31},
        {234, 31},
        {235, 31},
        {236, 31},
        {237, 31},
        {238, 31},
        {239, 31},
        {240, 31},
        {241, 31},
        {242, 31},
        {243, 31},
        {244, 31},
        {245, 31},
        {246, 31},
        {247, 31},
        {248, 31},
        {249, 31},
        {250, 31},
        {251, 31},
        {252, 31},
        {253, 31},
        {254, 31},
        {255, 31},
        {48, 36},
        {49, 36},
        {50, 36},
        {51, 36},
        {52, 36},
        {53, 36},
        {54, 36},
        {55, 36},
        {56, 36},
        {57, 36},
        {65, 32},
        {66, 32},
        {67, 32},
        {68, 32},
        {69, 32},
        {70, 32},
        {71, 32},
        {72, 32},
        {73, 32},
        {74, 32},
        {75, 32},
        {76, 32},
        {77, 32},
        {78, 32},
        {79, 32},
        {80, 32},
        {81, 32},
        {82, 32},
        {83, 32},
        {84, 32},
        {85, 32},
        {86, 32},
        {87, 32},
        {88, 32},
        {89, 32},
        {90, 32},
        {97, 36},
        {98, 36},
        {99, 36},
        {100, 36},
        {101, 36},
        {102, 36},
        {103, 36},
        {104, 36},
        {105, 36},
        {106, 36},
        {107, 36},
        {108, 36},
        {109, 36},
        {110, 36},
        {111, 36},
        {112, 36},
        {113, 36},
        {114, 36},
        {115, 36},
        {116, 36},
        {117, 36},
        {118, 36},
        {119, 36},
        {120, 36},
        {121, 36},
        {122, 36},
        {48, 37},
        {49, 37},
        {50, 37},
        {51, 37},
        {52, 37},
        {53, 37},
        {54, 37},
        {55, 37},
        {56, 37},
        {57, 37},
        {65, 38},
        {66, 38},
        {67, 38},
        {68, 38},
        {69, 38},
        {70, 38},
        {71, 38},
        {72, 38},
        {73, 38},
        {74, 38},
        {75, 38},
        {76, 38},
        {77, 38},
        {78, 38},
        {79, 38},
        {80, 38},
        {81, 38},
        {82, 38},
        {83, 38},
        {84, 38},
        {85, 38},
        {86, 38},
        {87, 38},
        {88, 38},
        {89, 38},
        {90, 38},
        {97, 37},
        {98, 37},
        {99, 37},
        {100, 37},
        {101, 37},
        {102, 37},
        {103, 37},
        {104, 37},
        {105, 37},
        {106, 37},
        {107, 37},
        {108, 37},
        {109, 37},
        {110, 37},
        {111, 37},
        {112, 37},
        {113, 37},
        {114, 37},
        {115, 37},
        {116, 37},
        {117, 37},
        {118, 37},
        {119, 37},
        {120, 37},
        {121, 37},
        {122, 37},
        {48, 37},
        {49, 37},
        {50, 37},
        {51, 37},
        {52, 37},
        {53, 37},
        {54, 37},
        {55, 37},
        {56, 37},
        {57, 37},
        {97, 37},
        {98, 37},
        {99, 37},
        {100, 37},
        {101, 37},
        {102, 37},
        {103, 37},
        {104, 37},
        {105, 37},
        {106, 37},
        {107, 37},
        {108, 37},
        {109, 37},
        {110, 37},
        {111, 37},
        {112, 37},
        {113, 37},
        {114, 37},
        {115, 37},
        {116, 37},
        {117, 37},
        {118, 37},
        {119, 37},
        {120, 37},
        {121, 37},
        {122, 37},
        {60, 40},
        {10, 1}
    };

        public readonly int[] TOKEN_STATE = { -2, 0, 22, -1, -1, 34, 35, 29, 27, 31, 28, 30, 3, 3, 32, 25, 33, 26, 6, 6, -1, 24, 5, -1, 20, -1, 23, -2, -2, 21, 4, -2, 2, 2, -1, -2, 2, 2, 2, -2, 0 };

        public readonly int[] SPECIAL_CASES_INDEXES =
            { 0, 0, 0, 0, 0, 0, 0, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13 };

        public readonly string[] SPECIAL_CASES_KEYS =
            {  "elif", "else", "end", "false", "if", "main", "read", "repeat", "true", "until", "while", "write", "writeln" };

        public readonly int[] SPECIAL_CASES_VALUES =
            {  10, 11, 8, 12, 9, 7, 14, 17, 13, 18, 19, 15, 16 };

        public readonly string[] SCANNER_ERROR =
        {
        "símbolo inválido",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "constante_string inválida",
        "símbolo inválido",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "símbolo inválido",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "constante_string inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "comentário de bloco inválido ou não finalizado",
        "identificador inválido",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "comentário de bloco inválido ou não finalizado",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "palavra reservada inválida",
        "comentário de bloco inválido ou não finalizado",
        "palavra reservada inválida"
    };
    }
}
