using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using ModelCartera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ControlTotal
{
    internal class GoogleDoc : GoogleDocDriveV3
    {
        private DriveService GetService_v2()
        {
            string[] Scopes = { DriveService.Scope.Drive };
            UserCredential credential;
            using (var stream = new System.IO.FileStream("client_secre.json", System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
            }

            //Create Drive API service.
            DriveService service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "GoogleDriveRestAPI-v2",
            });
            return service;
        }

        public List<googledrivefile> GetContainsInFolder(string folderId)
        {
            List<string> ChildList = new List<string>();
            DriveService ServiceV2 = GetService_v2();
            ChildrenResource.ListRequest ChildrenIDsRequest = ServiceV2.Children.List(folderId);
            do
            {
                var children = ChildrenIDsRequest.Execute();
                if (children.Items != null && children.Items.Count > 0)
                {
                    foreach (var file in children.Items)
                    {
                        ChildList.Add(file.Id);
                    }
                }
                ChildrenIDsRequest.PageToken = children.NextPageToken;
            }
            while (!string.IsNullOrEmpty(ChildrenIDsRequest.PageToken));

            //Get All File List
            List<googledrivefile> AllFileList = GetDriveFiles();
            List<googledrivefile> Filter_FileList = new List<googledrivefile>();

            foreach (string Id in ChildList)
            {
                Filter_FileList.Add(AllFileList.Where(x => x.IdGoogle == Id).FirstOrDefault());
            }
            return Filter_FileList;
        }

        private void RenameFile(string fileId, string newTitle)
        {
            try
            {
                DriveService service = GetService_v2();
                File file = new File();
                file.Title = newTitle;
                FilesResource.PatchRequest request = service.Files.Patch(file, fileId);
                File updatedFile = request.Execute();
            }
            catch (Exception)
            {
                // return null;
            }
        }

        public List<File> retrieveAllFiles()
        {
            DriveService service = GetService_v2();
            List<File> result = new List<File>();
            FilesResource.ListRequest request = service.Files.List();
            do
            {
                try
                {
                    FileList files = request.Execute();
                    result.AddRange(files.Items);
                    request.PageToken = files.NextPageToken;
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                    request.PageToken = null;
                }
            } while (!String.IsNullOrEmpty(request.PageToken));
            return result;
        }
    }
}