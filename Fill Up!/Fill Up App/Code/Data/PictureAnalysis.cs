using Android.Graphics;

namespace Fill_Up_App.Code.Data
{
    public class PictureAnalysis
    {
        //apskaičiuoja kiek procentų nuotraukos (pagal aukštį) užima alaus spalva
        public int GetBeerPercentage(Bitmap image)
        {
            Color color, newColor;
            int middlePixelHeight = image.Height / 2; 
            int middlePixelWidth = image.Width / 2;
            int i, pix, pixel, numberOfPixels = 0;
            pix = image.GetPixel(middlePixelWidth, middlePixelHeight);
            color = Color.Argb(pix, pix, pix, pix);   //gaunama nuotraukos vidurinio pixelio spalva (alaus)
            for (i = image.Height - 1; i >= 0; i--)   //nuo nuotraukos apačios kylama į viršų per  vidurį ir skaičiuojama kiek pixelių yra panašios į vidurinio nuotraukos pixelio (alaus) spalvos.
            {
                pixel = image.GetPixel(middlePixelWidth, i);
                newColor = Color.Argb(pixel, pixel, pixel, pixel);  //kiekvieno pixelio kylant aukščiau spalva lyginimui su alaus spalva
                if ((newColor.R >= color.R - 0xA && newColor.R <= color.R + 0xA) ||
                    (newColor.G >= color.G - 0xA && newColor.G <= color.G + 0xA) ||
                    (newColor.B >= color.B - 0xA && newColor.B <= color.B + 0xA))
                    numberOfPixels++;
            }

            int result = numberOfPixels * 90 / image.Height;  //apskaičiuojami procentai kiek alaus spalva užima nuotraukos aukščio
            return result;
        }
    }
}