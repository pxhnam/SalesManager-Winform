using System.Drawing;
using System.IO;

namespace PR_SalesManager
{
    public class LoadImage
    {
        //Chuyển từ byte sang ảnh
        public Image ByteArrayToImage(byte[] b)
        {
            MemoryStream memoryStream = new MemoryStream(b);
            return Image.FromStream(memoryStream);
        }
        //Chuyển từ ảnh sang byte
        public byte[] ImageToByteArray(Image img)
        {
            MemoryStream memoryStream = new MemoryStream();
            img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            return memoryStream.ToArray();
        }
    }
}
