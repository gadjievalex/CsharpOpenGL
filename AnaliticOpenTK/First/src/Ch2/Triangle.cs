using OpenTK.Windowing.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.src.Ch2
{
    public class Triangle : GameWindow
    {
        public Triangle(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings)
            : base(gameWindowSettings, nativeWindowSettings)
        {
            
        }

        private readonly float[] _vertices =
        {
            -0.5f, -0.5f, 0.0f, // Bottom-left vertex
            0.5f, -0.5f, 0.0f, // Bottom-right vertex
            0.0f,  0.5f, 0.0f  // Top vertex
        };

        private int _vertexBufferObject;

        private int _vertexArrayObject;

        private Shader _shader;

    }
}
