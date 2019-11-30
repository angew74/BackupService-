using SQLiteDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDriveService;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Auth.OAuth2;
using System.Threading;
using Google.Apis.Util.Store;
using System.IO;
using File = Google.Apis.Drive.v3.Data.File;
using Google.Apis.Services;
using System.Configuration;

namespace GDriveService
{
    public class UploadApiServiceExt
    {       
        private string[] Scopes = new string[] { DriveService.Scope.Drive,
                                 DriveService.Scope.DriveFile};
        private string ApplicationName = "";

        public UploadApiServiceExt()
        {
            string[] Scopes = { DriveService.Scope.DriveReadonly };
            string ApplicationName = ConfigurationManager.AppSettings["googleNameApplication"];
        }

        public bool SetFile(SQLiteDB.Model.FileStream fileStream)
        {
            bool UploadOK = false;
            UserCredential userCredential = GetCredential();
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = userCredential,
                ApplicationName = ApplicationName,
            });

            var fileMetadata = new File()
            {
                // Name = "photo.jpg"
                Name = fileStream.Name
            };
            FilesResource.CreateMediaUpload request;
            //using (var stream = new System.IO.FileStream("files/photo.jpg",
            //                        System.IO.FileMode.Open))
            //{
            //    request = service.Files.Create(
            //        fileMetadata, stream, "image/jpeg");
            //    request.Fields = "id";
            //    request.Upload();
            //}
           using (var stream = new System.IO.FileStream(fileStream.Path,
                                    System.IO.FileMode.Open))
            {
                request = service.Files.Create(
                    fileMetadata, stream, fileStream.Extension);
                request.Fields = "id";
                request.Upload();
            }
            var file = request.ResponseBody;
            return UploadOK;
        }

        public bool GetFileApi()
        {
            bool UploadOK = false;
            UserCredential userCredential = GetCredential();
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = userCredential,
                ApplicationName = ApplicationName,
            });
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 10;
            listRequest.Fields = "nextPageToken, files(id, name)";

            // List files.
            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute()
                .Files;
            Console.WriteLine("Files:");
            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    Console.WriteLine("{0} ({1})", file.Name, file.Id);
                }
            }
            else
            {
                Console.WriteLine("No files found.");
            }
            Console.Read();
            return UploadOK;
        }


        public UserCredential GetCredential()
        {
            UserCredential credential;

            using (var stream =
                new System.IO.FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                  Environment.UserName,
                  CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            return credential;
        }


    }
}
