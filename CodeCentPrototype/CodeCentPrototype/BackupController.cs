using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCentPrototype
{
    public class BackupController
    {
        private Boolean PreviousUnfinishedBackup { get; set; }
        private Boolean PreviousUnfinishedRestore { get; set; }

        public int StartBackup()
        {
            // spin off to new thread - will we need to specify backup by year, or full system backup only?
            return 0; // FIXME
        }

        public int StopBackp()
        {
            return 0; // FIXME
        }

        public int StartRestore()
        {
            return 0; // FIXME
        }
        
    }
}
