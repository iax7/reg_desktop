using System;

namespace Registration
{
    public class Logger
    {
        protected readonly log4net.ILog Log;
        /// <summary>
        /// Creates an instance to write Logs using Type.Name
        /// </summary>
        /// <param name="type">Type of Module that will be logging.</param>
        public Logger(Type type)
        {
            Log = log4net.LogManager.GetLogger(type.Name);
        }

        public void Debug(string format, params object[] args)
        {
            Debug(String.Format(format, args));
        }
        public void Debug(string status, Exception ex = null)
        {
            status = Log.Logger.Name + "> " + status;
            Log.Debug(status, ex);
        }
        public void Info(string format, params object[] args)
        {
            Info(String.Format(format, args));
        }
        public void Info(string status, Exception ex = null)
        {
            status = Log.Logger.Name + "> " + status;
            Log.Info(status, ex);
        }
        public void Warning(string format, params object[] args)
        {
            Warning(String.Format(format, args));
        }
        public void Warning(string status, Exception ex = null)
        {
            status = Log.Logger.Name + "> " + status;
            Log.Warn(status, ex);
        }
        public void Error(Exception ex)
        {
            Error(ex.Message, ex);
        }
        public void Error(string format, params object[] args)
        {
            Error(String.Format(format, args));
        }
        public void Error(string status, Exception ex = null)
        {
            status = Log.Logger.Name + "> " + status;
            Log.Error(status, ex);

            if (ex != null)
            {
                Exception inner = ex.InnerException;
                while (inner != null)
                {
                    Log.Error("\t" + inner.Message, inner);
                    inner = inner.InnerException;
                }
            }
        }
        public void Fatal(string format, params object[] args)
        {
            Fatal(String.Format(format, args));
        }
        public void Fatal(string status, Exception ex = null)
        {
            status = Log.Logger.Name + "> " + status;
            Log.Fatal(status, ex);
        }
    }
}