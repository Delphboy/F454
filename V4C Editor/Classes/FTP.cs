using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace V4C_Editor
{
    //https://msdn.microsoft.com/en-us/library/ms229711%28v=vs.110%29.aspx  -> Download via FTP
    //https://msdn.microsoft.com/en-us/library/ms229715%28v=vs.110%29.aspx  -> Upload via FTP
    //https://msdn.microsoft.com/en-us/library/ms229716%28v=vs.110%29.aspx  -> View FTP Directory -> Use for Tree

    public static class FTP
    {
        public static List<string> directories = new List<string>();

        public static string host = "";
        public static string directory = "";
        public static string username = "";
        public static string password = "";

        public static bool isConnected = false;

        //establish connection to server -> return error message if fails
        public static string connect()
        {
            try
            {
                //TODO: return error if connection lost
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Disconnect from server and reset connection vars
        public static void disconnect()
        {
            //TODO: disconnect from server
            host = "";
            username = "";
            password = "";

            isConnected = false;
        }

        //download file
        public static string downloadFile(string nodeName)
        {
            try
            {
                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + host + "/" + directory + "/" + nodeName); //TODO: Allow file selection from tree view
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                // This example assumes the FTP site uses anonymous logon.
                request.Credentials = new NetworkCredential(username, password);

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                return reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "This is an invalid directory";
            }
        }

        //delete file from server
        public static void deleteFile(string nodeName)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + host + "/" + directory + "/" + nodeName);

            request.Credentials = new NetworkCredential(username, password);

            request.Method = WebRequestMethods.Ftp.DeleteFile;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Console.WriteLine("Delete status: {0}", response.StatusDescription);
            response.Close();
        }

        //upload file from PC
        public static void uploadFile(string fileLoc)
        {
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + host + "/" + directory  + "/" + Path.GetFileName(fileLoc)); 
            request.Method = WebRequestMethods.Ftp.UploadFile;

            Console.WriteLine("ftp://" + host + "/" + directory + "/" + Path.GetFileName(fileLoc));

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential(username, password);

            // Copy the contents of the file to the request stream.
            StreamReader sourceStream = new StreamReader(fileLoc);
            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            request.ContentLength = fileContents.Length;

            Console.WriteLine(sourceStream.ReadToEnd());

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Console.WriteLine("Upload File Complete, status {0}", response.StatusDescription);

            response.Close();
        }

        public static void doneEditing(string nodeName, string uploadData)
        {
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + host + "/" + directory + "/" + nodeName); //TODO: Allow file selection from tree view
            request.Method = WebRequestMethods.Ftp.UploadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential(username, password);

            // Copy the contents of the file to the request stream.
            byte[] fileContents = Encoding.UTF8.GetBytes(uploadData);
            request.ContentLength = fileContents.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Console.WriteLine("Upload File Complete, status {0}", response.StatusDescription);

            response.Close();
        }

        //build the tree view tree
        //BREAK: Programme crashes if it can't resolve the host
        public static void buildTree()
        {
            directories.Clear();

            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + host + "/" + directory);
            ftpRequest.Credentials = new NetworkCredential(username, password);
            ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());

            string line = streamReader.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                directories.Add(line);
                line = streamReader.ReadLine();
            }

            streamReader.Close();
        }
    }
}