using System;
using System.Data.SqlClient;

namespace CodeExamples
{
    public class Disposable : IDisposable
    {
        bool disposed = false;
        public bool Disposed
        {
            get { return disposed; }
        }

        public SqlConnection toDisposeConnection;

        public Disposable()
        {
            toDisposeConnection = new SqlConnection();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                if (toDisposeConnection != null)
                    toDisposeConnection.Dispose();
            }

            disposed = true;
        }
    }
}
