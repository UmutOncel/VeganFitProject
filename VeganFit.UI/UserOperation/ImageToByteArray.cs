using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganFit.UI.UserOperation
{
    public static class ImageToByteArray
    {
        /// <summary>
        /// Image'ı byte dizisine çeviren ve bu byte dizisini döndüren metot.
        /// </summary>
        /// <param name="imageIn"></param>
        /// <returns></returns>
        public static byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();

            if (imageIn != null)
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            return ms.ToArray();
        }

        /// <summary>
        /// Byte dizisini image'a çeviren ve bu image'ı döndüren metot.
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns></returns>
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage=null;
            MemoryStream ms;
            if (byteArrayIn != null)
            {
                ms = new MemoryStream(byteArrayIn);
                returnImage = Image.FromStream(ms);
            }
            
            return returnImage;
        }
    }
}
