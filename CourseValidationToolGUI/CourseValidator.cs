using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CourseValidationToolGUI
{
    class CourseValidator
    {
        private string fileName;

        [DllImport("CourseValidationToolDll.dll")]
        public extern static int ExecuteValidation(string filename);
        public CourseValidator( string fileName )
        {
            this.fileName = fileName;
        }

        public bool Execute()
        {
            if( fileName is null)
            {
                return false;
            }

            int result = ExecuteValidation(fileName);
            if ( result == 1 )
            {
                return true;
            }
            return false;
        }
    }
}
