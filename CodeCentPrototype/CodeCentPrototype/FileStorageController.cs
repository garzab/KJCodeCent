using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCentPrototype
{
    public class FileStorageController
    {
        public string FileStoragePath { get; protected set; }

        public int OpenFile(string path)
        {
            return 0; // FIXME
        }

        public int DeleteFile(string path)
        {
            return 0; // FIXME
        }

        public int BackupFileStore(string outPath)
        {
            return 0; // FIXME - Add 7zip library and call from here
        }

        public int ArchiveStudentFiles(List<int> studentIDs)
        {
            return 0; // FIXME - 7zip all to-be-archived student records for export
        }


    }
}
