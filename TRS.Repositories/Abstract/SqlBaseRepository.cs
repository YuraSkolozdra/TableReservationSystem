namespace TRS.Repositories.Abstract
{
    public class SqlBaseRepository
    {
        #region Private fields

        protected readonly string _connectionString;

        #endregion

        #region Constructors

        public SqlBaseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #endregion
    }
}
