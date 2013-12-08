﻿using System.Drawing;
using SharpexGL.Framework.Content;
using SharpexGL.Framework.Content.Factory;
using SharpexGL.Framework.Rendering.GDI;

namespace SharpexGL.Framework.Rendering.Sprites.GDI
{
    public class SpriteSheet : IContent
    {
        /// <summary>
        /// Initializes a new Sprite class.
        /// </summary>
        internal SpriteSheet(Bitmap rawTexture)
        {
            _rawTexture = rawTexture;
            RawTexture = rawTexture;
            _spriteBuffer = new SpriteBuffer();
        }

        /// <summary>
        /// Static ctor.
        /// </summary>
        static SpriteSheet()
        {
            Factory = new SpriteSheetFactory();
        }

        /// <summary>
        /// Sets or gets the SpriteSheetFactory.
        /// </summary>
        public static SpriteSheetFactory Factory { get; private set; }

        private readonly Bitmap _rawTexture;
        private readonly SpriteBuffer _spriteBuffer;
        internal Bitmap RawTexture;

        /// <summary>
        /// Gets a single Sprite based on the given coords, width and height.
        /// </summary>
        /// <param name="x">The X-Coord.</param>
        /// <param name="y">The Y-Coord.</param>
        /// <param name="width">The Width.</param>
        /// <param name="height">The Height.</param>
        /// <returns>Texture</returns>
        public GdiTexture GetSprite(int x, int y, int width, int height)
        {
            GdiTexture textureParam;
            if (_spriteBuffer.IsBuffered(x, y, width, height))
            {
                textureParam = new GdiTexture(_spriteBuffer.GetBuffer());
            }
            else
            {
                textureParam =
                    new GdiTexture(_rawTexture.Clone(new Rectangle(x, y, width, height), _rawTexture.PixelFormat));
                _spriteBuffer.SetBuffer(x, y, width, height, textureParam.Bmp);
            }
            return textureParam;
        }

    }
}