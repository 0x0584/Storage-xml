using System.Data.SqlClient;

namespace MagApp
{
    class SqlServer
    {
        private SqlConnection connection;
        private SqlCommand commander;
        private SqlDataReader reader;

        public SqlServer()
        {
            this.connection = new SqlConnection();
            this.commander = new SqlCommand();
            this.commander.Connection = this.connection;
        }
        #region props
        public SqlDataReader Reader
        {
            get { return reader; }
            set { reader = value; }
        }
        public SqlCommand Commander
        {
            get { return commander; }
            set { commander = value; }
        }
        public SqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }
        #endregion
    }
}
