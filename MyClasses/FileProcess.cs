using System.IO;
using System;

namespace MyClasses
{
    public class FileProcess
    {
        public bool FileExists(string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                throw new ArgumentNullException();
            }

            bool result = File.Exists(filename);
            return result;
        }
    }
}
