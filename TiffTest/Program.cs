using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitMiracle.LibTiff.Classic;

namespace TiffTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyStream stream = new MyStream();
            //using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            //{
            //    // Open the TIFF image for reading 
            //    using (Tiff image = Tiff.ClientOpen("custom", "w", ms, stream))
            //    {
            //        if (image == null)
            //            return;
            //        image.SetField(TiffTag.IMAGEWIDTH, 1280);
            //        image.SetField(TiffTag.IMAGELENGTH, 8000);
            //        image.Flush();
            //        // Read image data here the same way 
            //        // as if LibTiff.Net was using regular image file
            //        image.Close();
            //    }
            //}
            //Console.WriteLine("test");
            //Console.Read();
            Tiff tif = CreateTiffFile(1024, 1024, new byte[1024], 16);
            Console.WriteLine("test");
        }

        public static Tiff CreateTiffFile(int width, int height, byte[] imgData, int bitsPerSample = 16)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (Tiff tif = Tiff.ClientOpen("InMemory", "w", ms, new TiffStream()))
                {
                    if (tif == null)
                        return null;

                    tif.SetField(TiffTag.IMAGEWIDTH, width);
                    tif.SetField(TiffTag.IMAGELENGTH, height);
                    tif.SetField(TiffTag.SAMPLESPERPIXEL, 1);
                    tif.SetField(TiffTag.BITSPERSAMPLE, bitsPerSample);
                    tif.SetField(TiffTag.ORIENTATION, Orientation.TOPLEFT);
                    tif.SetField(TiffTag.ROWSPERSTRIP, height);
                    tif.SetField(TiffTag.PLANARCONFIG, PlanarConfig.CONTIG);
                    tif.SetField(TiffTag.PHOTOMETRIC, Photometric.MINISBLACK);
                    tif.SetField(TiffTag.COMPRESSION, Compression.NONE);

                    // fill samples array
                    tif.WriteEncodedStrip(0, imgData, imgData.Length);
                    //tif.Flush();

                    byte[] bs = ms.GetBuffer();
                    List<byte> bb = new List<byte>();
                    foreach (var item in bs)
                    {
                        if (item != 0)
                        {
                            bb.Add(item);
                        }
                    }

                    return tif;
                }
            }
        }
    }

    class MyStream : TiffStream
    {
        // You may implement any constructor you want here. 

        //public override int Read(object clientData, byte[] buffer, int offset, int count)
        //{
        //    // stub implementation 
        //    return -1;
        //}

        public override void Write(object clientData, byte[] buffer, int offset, int count)
        {
            base.Write(clientData, buffer, offset, count);
        }

        public override long Seek(object clientData, long offset, System.IO.SeekOrigin whence)
        {
            // stub implementation 
            return -1;
        }

        public override void Close(object clientData)
        {
            // stub implementation
        }

        public override long Size(object clientData)
        {
            // stub implementation 
            return -1;
        }
    }
}
