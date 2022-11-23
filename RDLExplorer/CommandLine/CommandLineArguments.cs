using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RDLExplorer.CommandLine
{
    public class Arguments
    {
        #region Main Parameters

        [DefaultArgument(ArgumentType.AtMostOnce, GroupName = "Main", HelpText = "The RDL file to explore")]
        public string FileName;

        #endregion

        #region Optional

        #endregion

        #region Standalone

        [Argument(ArgumentType.BypassMandatory, DefaultValue = false, ShortName = "?", GroupName = "Standalone", HelpText = "Show this Help page")]
        public bool Help;

        #endregion

        #region Properties

        public bool HasFileName
        {
            get { return !string.IsNullOrEmpty(FileName); }
        }

        #endregion
    }
}
