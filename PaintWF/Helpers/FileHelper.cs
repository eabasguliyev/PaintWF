namespace PaintWF.Helpers
{
    public class FileHelper
    {
        public string GetSafeFileName(string fileName, string extension)
        {
            return fileName.EndsWith(extension) ? fileName : fileName + extension;
        }
    }
}