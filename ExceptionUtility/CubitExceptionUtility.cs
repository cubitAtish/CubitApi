using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionUtility
{
    public class CubitExceptionUtility
    {
        /// <summary>
        /// Writes the current Date and time along with the exception Message
        /// </summary>
        /// <param name="logMessage"></param>
        /// <param name="w"></param>
        public static void CubitExceptionLog(string logMessage, string Filename, string Time, string Date)
        {
            log4net.ILog logger = LogManager.GetLogger(typeof(CubitExceptionUtility));
            logger.Error("Exception Message : " + logMessage + " " + "Exception Origination Class :" + Filename + " " + "Exception Date and Time :" + Date + Time);
            logger.Error("\n__________________________________________________________________________________________________________________________");
        }
    }
}
