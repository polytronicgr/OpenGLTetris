﻿using OpenGLTetris.Shapes;
using OpenTK.Graphics.OpenGL;

namespace OpenGLTetris.Blocks.BlockTypes
{
    public class Square : BaseBlock
    {
        public Square(double sizeUnit) : base(sizeUnit) { }

        public override void Draw()
        {
            GL.PushMatrix();

            GL.Color3(Color);

            Cube.Draw(SizeUnit);

            GL.Translate(2 * SizeUnit, 0, 0);
            Cube.Draw(SizeUnit);

            GL.Translate(0, 2 * SizeUnit, 0);
            Cube.Draw(SizeUnit);

            GL.Translate(-2 * SizeUnit, 0, 0);
            Cube.Draw(SizeUnit);

            GL.PopMatrix();
        }

        public override void Rotate() { }
    }
}
