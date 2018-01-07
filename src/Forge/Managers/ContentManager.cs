using System;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace Forge.Managers
{
    public static class ContentManager
    {
        private static string currentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); // Get the execution directory.

        public static string contentDirectory = ContentManager.GetDirectory("\\Content", true); // Where data relating to tiles is stored.

        public static FileStream GetFile(string path, bool isRelative) // Returns a single file.
        {
            FileStream file;

            if (isRelative == true) // If the path defined in parameters is relative to the execution directory...
            {
                path = currentDirectory + path; // Append the path defined to the execution directory.
            }
            if (File.Exists(path)) // Ensure that a file exists at the defined path.
            {
                file = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read); // Attempt to open the file.
                return file;
            }
            else
            {
                return null; // If the file does not exist then we return null.
            }
        }

        public static Image GetImage(string path, bool isRelative) // Returns a single image file.
        {
            Image image;

            if (isRelative == true)
            {
                path = currentDirectory + path;
            }

            if (File.Exists(path))
            {
                image = Image.FromFile(path, true);
                return image;
            }
            else
            {
                return null;
            }
        }

        public static string GetDirectory(string path, bool isRelative) // Returns a directory.
        {
            if (isRelative == true)
            {
                path = currentDirectory + path;
            }

            if (Directory.Exists(path))
            {
                return path;
            }
            else
            {
                return null;
            }
        }

        public static string[] GetDirectoryContent(string path, bool isRelative) // Returns the contents of a directory.
        {
            string[] directoryContent;

            if (isRelative == true)
            {
                path = currentDirectory + path;
            }

            if (Directory.Exists(path))
            {
                directoryContent = Directory.GetFiles(path);
                return directoryContent;
            }
            else
            {
                return null;
            }
        }
    }
}