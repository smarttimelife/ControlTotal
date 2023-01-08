namespace ControlTotal
{
    #region Librerias

    using Google.Apis.Auth.OAuth2;
    using Google.Apis.Download;
    using Google.Apis.Drive.v3;
    using Google.Apis.Drive.v3.Data;
    using Google.Apis.Services;
    using Google.Apis.Util.Store;
    using ModelCartera;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Web;

    #endregion Librerias

    public abstract class GoogleDocDriveV3
    {
        #region Propiedades

        public event DlgteGoogleDrive Ok_Event_GoogleDoc;

        public event DlgteGoogleDrive Error_Event_GoogleDoc;

        public event DlgteString Error_Event_String;

        public event DlgteString Ok_Event_String;

        #endregion Propiedades

        public GoogleDocDriveV3()
        {
        }

        #region Metodos

        private DriveService GetService()
        {
            UserCredential credential;
            string[] Scopes = { DriveService.Scope.Drive };
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
            DriveService service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "GoogleDriveRestAPI-v3",
            });
            return service;
        }

        public void FileUpload(string path, string filename)
        {
            googledrivefile googleDrive = new googledrivefile();
            string IdDocumento = string.Empty;
            try
            {
                DriveService serveces = GetService();
                var mimetype = MimeMapping.GetMimeMapping(filename);
                var metadata = new File() { Name = filename };
                FilesResource.CreateMediaUpload request;
                using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Open))
                {
                    request = serveces.Files.Create(metadata, stream, mimetype);
                    request.Fields = "id";
                    request.Upload();
                }
                var file = request.ResponseBody;
                googleDrive = new googledrivefile
                {
                    IdGoogle = file.Id,
                    Name = file.Name,
                    Size = file.Size,
                    Version = file.Version,
                    CreatedTime = file.CreatedTime,
                    Parents = file.Parents,
                    MimeType = file.MimeType,
                    WebViewLink = file.WebViewLink,
                    WebContentLink = file.WebContentLink
                };
                Ok_Event_GoogleDoc("Registro Adicionado Correctamente", googleDrive);
            }
            catch (System.Exception ex)
            {
                Error_Event_GoogleDoc(ex.Message, googleDrive);
            }
        }

        public void FileUploadInFolder(string folderId, string path, string filename)
        {
            googledrivefile googleDrive = new googledrivefile();
            try
            {
                DriveService serveces = GetService();
                var mimetype = MimeMapping.GetMimeMapping(filename);
                var metadata = new File()
                {
                    Name = filename,
                    MimeType = MimeMapping.GetMimeMapping(path),
                    Parents = new List<string>
                    {
                        folderId
                    }
                };
                FilesResource.CreateMediaUpload request;
                using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Open))
                {
                    request = serveces.Files.Create(metadata, stream, mimetype);
                    request.Fields = "id";
                    request.Upload();
                }
                var file = request.ResponseBody;
                googleDrive = new googledrivefile
                {
                    IdGoogle = file.Id,
                    Name = file.Name,
                    Size = file.Size,
                    Version = file.Version,
                    CreatedTime = file.CreatedTime,
                    Parents = file.Parents,
                    MimeType = file.MimeType,
                    WebViewLink = file.WebViewLink,
                    WebContentLink = file.WebContentLink
                };

                Ok_Event_GoogleDoc("Registro Adicionado Correctamente", googleDrive);
            }
            catch (System.Exception ex)
            {
                Error_Event_GoogleDoc(ex.Message, googleDrive);
            }
        }

        public List<googledrivefile> GetDriveFiles()
        {
            DriveService service = GetService();
            FilesResource.ListRequest FileListRequest = service.Files.List();
            FileListRequest.Fields = "nextPageToken, files(*)";
            IList<File> files = FileListRequest.Execute().Files;
            List<googledrivefile> FileList = new List<googledrivefile>();
            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    googledrivefile File = new googledrivefile
                    {
                        IdGoogle = file.Id,
                        Name = file.Name,
                        Size = file.Size,
                        Version = file.Version,
                        CreatedTime = file.CreatedTime,
                        Parents = file.Parents,
                        MimeType = file.MimeType,
                        WebViewLink = file.WebViewLink,
                        WebContentLink = file.WebContentLink
                    };
                    FileList.Add(File);
                }
            }
            return FileList;
        }

        public List<googledrivefile> GetDriveFolders()
        {
            DriveService service = GetService();
            List<googledrivefile> FolderList = new List<googledrivefile>();

            Google.Apis.Drive.v3.FilesResource.ListRequest request = service.Files.List();
            request.Q = "mimeType='application/vnd.google-apps.folder'";
            request.Fields = "files(id, name)";

            Google.Apis.Drive.v3.Data.FileList result = request.Execute();
            foreach (var file in result.Files)
            {
                googledrivefile File = new googledrivefile
                {
                    IdGoogle = file.Id,
                    Name = file.Name,
                    Size = file.Size,
                    Version = file.Version,
                    CreatedTime = file.CreatedTime,
                    Parents = file.Parents,
                    MimeType = file.MimeType,
                    WebViewLink = file.WebViewLink,
                    WebContentLink = file.WebContentLink,
                };
                FolderList.Add(File);
            }
            return FolderList;
        }

        public string GetIdDocumento(string Name)
        {
            string strid = string.Empty;
            DriveService service = GetService();
            FilesResource.ListRequest FileListRequest = service.Files.List();
            FileListRequest.Fields = "nextPageToken, files(*)";
            IList<File> files = FileListRequest.Execute().Files;
            List<googledrivefile> FileList = new List<googledrivefile>();

            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    if (file.Name == Name)
                    {
                        strid = file.Id;
                    }
                }
            }
            return strid;
        }

        public bool CheckFolder(string FolderName)
        {
            bool IsExist = false;
            DriveService service = GetService();
            // Define parameters of request.
            FilesResource.ListRequest FileListRequest = service.Files.List();
            FileListRequest.Fields = "nextPageToken, files(*)";
            // List files.
            IList<File> files = FileListRequest.Execute().Files;
            List<googledrivefile> FileList = new List<googledrivefile>();
            //For getting only folders
            files = files.Where(x => x.MimeType == "application/vnd.google-apps.folder" && x.Name == FolderName).ToList();

            if (files.Count > 0)
            {
                IsExist = false;
            }
            return IsExist;
        }

        public string CopyFiles(string fileId, string folderId)
        {
            DriveService service = GetService();

            // Retrieve the existing parents to remove
            FilesResource.GetRequest getRequest = service.Files.Get(fileId);
            getRequest.Fields = "parents";
            File file = getRequest.Execute();

            // Copy the file to the new folder
            FilesResource.UpdateRequest updateRequest = service.Files.Update(new File(), fileId);
            updateRequest.Fields = "id, parents";
            updateRequest.AddParents = folderId;
            //updateRequest.RemoveParents = previousParents;
            file = updateRequest.Execute();
            if (file != null)
            {
                return "Success";
            }
            else
            {
                return "Fail";
            }
        }

        public void CreateFolder(string FolderName)
        {
            DriveService service = GetService();

            var FileMetaData = new File();
            FileMetaData.Name = FolderName;
            FileMetaData.MimeType = "application/vnd.google-apps.folder";

            FilesResource.CreateRequest request;

            request = service.Files.Create(FileMetaData);
            request.Fields = "id";
            var file = request.Execute();
            Console.WriteLine("Folder ID: " + file.Id);
        }

        public void CreateFolderInFolder(string folderId, string FolderName)
        {
            DriveService service = GetService();
            var FileMetaData = new Google.Apis.Drive.v3.Data.File()
            {
                Name = System.IO.Path.GetFileName(FolderName),
                MimeType = "application/vnd.google-apps.folder",
                Parents = new List<string>
                    {
                        folderId
                    }
            };

            FilesResource.CreateRequest request;
            request = service.Files.Create(FileMetaData);
            request.Fields = "id";
            var file = request.Execute();
            Console.WriteLine("Folder ID: " + file.Id);
            var file1 = request;
        }

        public void DeleteFile(googledrivefile files)
        {
            DriveService service = GetService();
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (files == null)
                    throw new ArgumentNullException(files.IdGoogle);
                // Make the request.
                service.Files.Delete(files.IdGoogle).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Files.Delete failed.", ex);
            }
        }

        public string DownloadGoogleFile(string fileId)
        {
            string target = @"c:\temp";
            System.IO.MemoryStream stream1 = new System.IO.MemoryStream();
            string FilePath = string.Empty;
            try
            {
                DriveService service = GetService();
                if (!System.IO.Directory.Exists(target))
                {
                    System.IO.Directory.CreateDirectory(target);
                }
                FilesResource.GetRequest request = service.Files.Get(fileId);
                string FileName = request.Execute().Name;
                FilePath = System.IO.Path.Combine(target, FileName);
                request.MediaDownloader.ProgressChanged += (Google.Apis.Download.IDownloadProgress progress) =>
                {
                    switch (progress.Status)
                    {
                        case DownloadStatus.Downloading:
                            {
                                Console.WriteLine(progress.BytesDownloaded);
                                break;
                            }
                        case DownloadStatus.Completed:
                            {
                                SaveStream(stream1, FilePath);
                                Ok_Event_String("Descarga completa Ruta: " + FilePath);
                                break;
                            }
                        case DownloadStatus.Failed:
                            {
                                Error_Event_String("Descarga Fallo");
                                break;
                            }
                    }
                };
                request.Download(stream1);
                return FilePath;
            }
            catch (Exception ex)
            {
                Error_Event_String(ex.Message);
            }
            return FilePath;
        }

        public System.IO.MemoryStream DownloaaFile(string fileId)
        {
            System.IO.MemoryStream stream2 = new System.IO.MemoryStream();
            try
            {
                DriveService service = GetService();
                FilesResource.GetRequest request = service.Files.Get(fileId);
                string FileName = request.Execute().Name;
                request.Download(stream2);
                return stream2;
            }
            catch (Exception ex)
            {
                Error_Event_String(ex.Message);
            }
            return stream2;
        }

        private static void SaveStream(System.IO.MemoryStream stream, string FilePath)
        {
            using (System.IO.FileStream file = new System.IO.FileStream(FilePath, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
            {
                stream.WriteTo(file);
            }
        }

        public string MoveFiles(string fileId, string folderId)
        {
            DriveService service = GetService();

            // Retrieve the existing parents to remove
            FilesResource.GetRequest getRequest = service.Files.Get(fileId);
            getRequest.Fields = "parents";
            File file = getRequest.Execute();
            string previousParents = string.Join(",", file.Parents);

            // Move the file to the new folder
            FilesResource.UpdateRequest updateRequest = service.Files.Update(new File(), fileId);
            updateRequest.Fields = "id, parents";
            updateRequest.AddParents = folderId;
            updateRequest.RemoveParents = previousParents;

            file = updateRequest.Execute();
            if (file != null)
            {
                return "Success";
            }
            else
            {
                return "Fail";
            }
        }

        #endregion Metodos
    }
}