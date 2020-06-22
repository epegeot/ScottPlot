﻿//This is a cmocean colormap
//All credit to Kristen Thyng
//This colormap is under the MIT License
//All cmocean colormaps are available at https://github.com/matplotlib/cmocean/tree/master/cmocean/rgb

namespace ScottPlot.Drawing.Colormaps
{
    public class Rain : IColormap
    {
        public (byte r, byte g, byte b) GetRGB(byte value) =>
            (cmaplocal[value, 0], cmaplocal[value, 1], cmaplocal[value, 2]);

        private static readonly byte[,] cmaplocal = {
            { 238, 237, 243 },
            { 238, 236, 241 },
            { 237, 235, 240 },
            { 236, 234, 238 },
            { 235, 233, 236 },
            { 235, 232, 235 },
            { 234, 231, 233 },
            { 233, 230, 232 },
            { 232, 229, 230 },
            { 232, 228, 229 },
            { 231, 227, 227 },
            { 230, 226, 226 },
            { 229, 225, 224 },
            { 228, 223, 223 },
            { 228, 222, 221 },
            { 227, 221, 220 },
            { 227, 220, 218 },
            { 226, 219, 216 },
            { 226, 218, 214 },
            { 225, 217, 212 },
            { 224, 216, 211 },
            { 224, 215, 209 },
            { 223, 214, 207 },
            { 223, 213, 205 },
            { 222, 212, 203 },
            { 222, 211, 201 },
            { 221, 209, 199 },
            { 221, 208, 197 },
            { 220, 207, 195 },
            { 220, 206, 193 },
            { 219, 205, 191 },
            { 219, 204, 190 },
            { 219, 203, 188 },
            { 218, 202, 186 },
            { 218, 201, 184 },
            { 217, 200, 182 },
            { 216, 199, 180 },
            { 216, 198, 178 },
            { 215, 197, 176 },
            { 215, 196, 174 },
            { 214, 195, 172 },
            { 213, 194, 170 },
            { 213, 193, 168 },
            { 212, 192, 166 },
            { 211, 191, 164 },
            { 210, 191, 162 },
            { 209, 190, 160 },
            { 208, 189, 158 },
            { 207, 188, 156 },
            { 205, 188, 155 },
            { 204, 187, 153 },
            { 203, 186, 152 },
            { 201, 186, 150 },
            { 200, 185, 149 },
            { 198, 185, 148 },
            { 196, 184, 146 },
            { 195, 183, 145 },
            { 193, 183, 144 },
            { 192, 182, 143 },
            { 190, 182, 142 },
            { 188, 181, 141 },
            { 186, 181, 141 },
            { 185, 180, 140 },
            { 183, 179, 139 },
            { 181, 179, 138 },
            { 180, 178, 137 },
            { 178, 178, 137 },
            { 176, 177, 136 },
            { 174, 177, 135 },
            { 173, 176, 135 },
            { 171, 176, 134 },
            { 169, 175, 133 },
            { 168, 174, 133 },
            { 166, 174, 132 },
            { 164, 173, 132 },
            { 162, 173, 131 },
            { 161, 172, 130 },
            { 159, 172, 130 },
            { 157, 171, 129 },
            { 156, 170, 129 },
            { 154, 170, 128 },
            { 152, 169, 128 },
            { 150, 169, 127 },
            { 149, 168, 126 },
            { 147, 168, 126 },
            { 145, 167, 125 },
            { 144, 167, 125 },
            { 142, 166, 124 },
            { 140, 165, 124 },
            { 138, 165, 123 },
            { 137, 164, 123 },
            { 135, 164, 122 },
            { 133, 163, 122 },
            { 131, 163, 121 },
            { 130, 162, 120 },
            { 128, 161, 120 },
            { 126, 161, 119 },
            { 124, 160, 119 },
            { 122, 160, 118 },
            { 121, 159, 118 },
            { 119, 159, 117 },
            { 117, 158, 117 },
            { 115, 157, 117 },
            { 113, 157, 116 },
            { 111, 156, 116 },
            { 109, 156, 115 },
            { 107, 155, 115 },
            { 105, 155, 114 },
            { 103, 154, 114 },
            { 101, 154, 114 },
            { 100, 153, 113 },
            { 97, 152, 113 },
            { 95, 152, 113 },
            { 93, 151, 112 },
            { 91, 151, 112 },
            { 89, 150, 112 },
            { 87, 149, 111 },
            { 85, 149, 111 },
            { 83, 148, 111 },
            { 81, 148, 111 },
            { 79, 147, 110 },
            { 76, 147, 110 },
            { 74, 146, 110 },
            { 72, 145, 110 },
            { 70, 145, 110 },
            { 67, 144, 110 },
            { 65, 143, 110 },
            { 63, 143, 110 },
            { 61, 142, 110 },
            { 58, 141, 109 },
            { 56, 141, 109 },
            { 54, 140, 109 },
            { 52, 139, 109 },
            { 49, 139, 110 },
            { 47, 138, 110 },
            { 45, 137, 110 },
            { 43, 137, 110 },
            { 41, 136, 110 },
            { 38, 135, 110 },
            { 36, 134, 110 },
            { 34, 134, 110 },
            { 32, 133, 110 },
            { 30, 132, 110 },
            { 28, 131, 110 },
            { 27, 130, 110 },
            { 25, 129, 110 },
            { 23, 129, 110 },
            { 21, 128, 110 },
            { 20, 127, 110 },
            { 18, 126, 110 },
            { 17, 125, 110 },
            { 15, 124, 110 },
            { 14, 124, 110 },
            { 12, 123, 110 },
            { 11, 122, 110 },
            { 10, 121, 110 },
            { 9, 120, 110 },
            { 8, 119, 110 },
            { 7, 118, 110 },
            { 6, 117, 110 },
            { 6, 116, 110 },
            { 5, 116, 110 },
            { 5, 115, 110 },
            { 4, 114, 110 },
            { 4, 113, 110 },
            { 4, 112, 109 },
            { 3, 111, 109 },
            { 3, 110, 109 },
            { 3, 109, 109 },
            { 3, 108, 109 },
            { 4, 107, 109 },
            { 4, 107, 109 },
            { 4, 106, 108 },
            { 4, 105, 108 },
            { 5, 104, 108 },
            { 5, 103, 108 },
            { 6, 102, 108 },
            { 7, 101, 107 },
            { 7, 100, 107 },
            { 8, 99, 107 },
            { 9, 98, 107 },
            { 10, 97, 106 },
            { 11, 96, 106 },
            { 12, 95, 106 },
            { 13, 95, 105 },
            { 14, 94, 105 },
            { 15, 93, 105 },
            { 16, 92, 104 },
            { 17, 91, 104 },
            { 18, 90, 103 },
            { 19, 89, 103 },
            { 20, 88, 103 },
            { 21, 87, 102 },
            { 22, 86, 102 },
            { 22, 85, 101 },
            { 23, 84, 101 },
            { 24, 83, 100 },
            { 25, 82, 100 },
            { 26, 81, 99 },
            { 26, 80, 99 },
            { 27, 79, 98 },
            { 28, 78, 97 },
            { 28, 77, 97 },
            { 29, 76, 96 },
            { 30, 75, 95 },
            { 30, 74, 95 },
            { 31, 73, 94 },
            { 31, 72, 93 },
            { 32, 72, 93 },
            { 33, 71, 92 },
            { 33, 70, 91 },
            { 33, 69, 90 },
            { 34, 68, 90 },
            { 34, 67, 89 },
            { 35, 66, 88 },
            { 35, 65, 87 },
            { 35, 64, 86 },
            { 36, 63, 86 },
            { 36, 62, 85 },
            { 36, 61, 84 },
            { 36, 60, 83 },
            { 36, 59, 82 },
            { 37, 58, 81 },
            { 37, 57, 81 },
            { 37, 56, 80 },
            { 37, 55, 79 },
            { 37, 55, 78 },
            { 37, 54, 77 },
            { 37, 53, 76 },
            { 37, 52, 76 },
            { 37, 51, 75 },
            { 37, 50, 74 },
            { 37, 49, 73 },
            { 37, 48, 72 },
            { 37, 47, 72 },
            { 37, 46, 71 },
            { 37, 45, 70 },
            { 37, 44, 69 },
            { 37, 43, 69 },
            { 37, 42, 68 },
            { 36, 41, 67 },
            { 36, 40, 66 },
            { 36, 39, 66 },
            { 36, 39, 65 },
            { 36, 38, 64 },
            { 36, 37, 63 },
            { 35, 36, 63 },
            { 35, 35, 62 },
            { 35, 34, 61 },
            { 35, 33, 61 },
            { 35, 32, 60 },
            { 34, 31, 59 },
            { 34, 30, 58 },
            { 34, 29, 58 },
            { 34, 28, 57 },
            { 34, 27, 56 }

        };
    }
}

