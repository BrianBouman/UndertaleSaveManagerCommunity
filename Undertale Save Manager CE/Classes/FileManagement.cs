using System;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.ComponentModel;

namespace Undertale_Save_Manager_CE
{
    static class GetSaveFiles
    {
        static public void downloadSaves(string link) //Function to download the saves
        {
            if (!File.Exists(USM.FILE_TEMPZIP)) //If the zip isn't downloaded yet
            {
                WebClient client = new WebClient(); //Create a web client
                Uri url = new Uri(USM.LINK_SAVEFILES); //Create the Uri
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(extract); //Set the callback when finished
                client.DownloadFileAsync(url, USM.FILE_TEMPZIP); //Download the files
            }
            else
            {
                extractFile(); //Extract the files
            }
        }
        static void extract(object sender, AsyncCompletedEventArgs e)//Should speak for its self
        {
            extractFile();
        }

        static void extractFile()
        {
            ZipFile.ExtractToDirectory(USM.FILE_TEMPZIP, USM.DIR_SAVES); //Extract the save files
        }
    }
}
