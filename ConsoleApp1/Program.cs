using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.MemoryMappedFiles;
using System.IO;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var mmf = MemoryMappedFile.CreateFromFile(@"c:\内存映射文件.data", FileMode.OpenOrCreate, "公用名"))
            {
                //通过指定的 偏移量和大小 创建内存映射文件视图服务器
                using (var accessor = mmf.CreateViewAccessor(offset, length)) //偏移量，可以控制数据存储的内存位置；大小，用来控制存储所占用的空间
                {
                    //Marshal提供了一个方法集，这些方法用于分配非托管内存、复制非托管内存块、将托管类型转换为非托管类型，此外还提供了在与非托管代码交互时使用的其他杂项方法。

                    int size = Marshal.SizeOf(typeof(char));

                    //修改内存映射文件视图
                    for (long i = 0; i < length; i += size)
                    {
                        char c = accessor.ReadChar(i);
                        accessor.Write(i, ref c);
                    }
                }
            }
        }
    }
}
