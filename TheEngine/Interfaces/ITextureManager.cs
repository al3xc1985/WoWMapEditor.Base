﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheEngine.Handles;

namespace TheEngine.Interfaces
{
    public interface ITextureManager
    {
        TextureHandle LoadTexture(string path);
        TextureHandle LoadTextureArray(params string[] path);
        TextureHandle CreateTextureArray(int[][][] pixels, int width, int height);
    }
}
