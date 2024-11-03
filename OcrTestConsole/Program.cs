using Windows.Graphics.Imaging;
using Windows.Media.Ocr;

static string AskFilePath()
{
    Console.Write("Input file: ");
    return Console.ReadLine()!.Trim('"');
}

string filePath = args.LastOrDefault() ?? AskFilePath();
using var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
var decoder = await BitmapDecoder.CreateAsync(stream.AsRandomAccessStream());
var bitmap = await decoder.GetSoftwareBitmapAsync();
var engine = OcrEngine.TryCreateFromUserProfileLanguages();
var result = await engine.RecognizeAsync(bitmap);
Console.WriteLine(result.Text);