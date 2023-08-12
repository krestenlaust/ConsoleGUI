using System;

namespace GUI.Console
{
    public class RectangleSegment<T>
    {
        readonly Memory<T>[] rows;

        public RectangleSegment(T[] array, int width, int offsetX, int offsetY, int segmentWidth, int segmentHeight)
        {
            rows = new Memory<T>[segmentHeight];

            for (int i = 0; i < segmentHeight; i++)
            {
                rows[i] = new Memory<T>(array, (i + offsetY) * width + offsetX, segmentWidth);
            }
        }

        public T this[int x, int y]
        {
            get => rows[y].Span[x];
            set => rows[y].Span[y] = value;
        }

        public Span<T> GetRow(int y) => rows[y].Span;
    }
}
